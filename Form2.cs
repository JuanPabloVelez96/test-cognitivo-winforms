using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Juego
{
    
    public partial class Form2 : System.Windows.Forms.Form
    {
        int omisiones = 0;
        int totalIntentos = 0;
        int maxIntentos = 15;
        DateTime inicioTest;
        double tiempoTotal = 0;
        bool esperandoClick = false;
        int glowPaso = 0;
        int errores = 0;
        int aciertos = 0;
        int shakePaso = 0;
        int erroresMaximos = 2;






        Timer timerGlow = new Timer();
        
        Random random = new Random();

        Timer timer = new Timer();

        Timer timerShake = new Timer();

        Color currentColor;

        Point posicionOriginal;

        public Form2()
            {
                InitializeComponent();

            timerGlow.Interval = 30;
            timerGlow.Tick += TimerGlow_Tick;

            timer.Interval = 1000; // 1 segundo
                timer.Tick += Timer_Tick;

                panelColor.BackColor = Color.White;

            timerShake.Interval = 20;
            timerShake.Tick += TimerShake_Tick;

            posicionOriginal = panelColor.Location;

        }
        private void ActivarGlow()
        {
            glowPaso = 0;
            timerGlow.Start();
        }

        private void ActivarError()
        {
            shakePaso = 0;
            posicionOriginal = panelColor.Location;
            timerShake.Start();
        }



        private void TimerGlow_Tick(object sender, EventArgs e)
        {
            glowPaso++;

            int intensidad = 50 - glowPaso * 5; // va bajando

            if (intensidad < 0)
            {
                timerGlow.Stop();
                panelColor.BackColor = BackColor;
                return;
            }

            panelColor.BackColor = Color.FromArgb(
                Math.Min(255, currentColor.R + intensidad),
                Math.Min(255, currentColor.G + intensidad),
                Math.Min(255, currentColor.B + intensidad)
            );
        }

        private void TimerShake_Tick(object sender, EventArgs e)
        {
            shakePaso++;

            int desplazamiento = (shakePaso % 2 == 0) ? 5 : -5;

            panelColor.Location = new Point(
                posicionOriginal.X + desplazamiento,
                posicionOriginal.Y
            );

            if (shakePaso > 10)
            {
                timerShake.Stop();
                panelColor.Location = posicionOriginal;
            }
        }

        private void btnStart_Click_1(object sender, EventArgs e)
            {
            aciertos = 0;
            errores = 0;
            omisiones = 0;
            totalIntentos = 0;

            lblScore.Text = "Aciertos: 0 | Errores: 0";
            lblInfo.Text = "Iniciando...";

            inicioTest = DateTime.Now;

            timer.Start();
        }

            private void Timer_Tick(object sender, EventArgs e)
            {
            if (currentColor == Color.Red && esperandoClick)
            {
                omisiones++;
            }

            currentColor = GetRandomColor();
            panelColor.BackColor = currentColor;

            esperandoClick = true;

            totalIntentos++;

            if (totalIntentos >= maxIntentos)
            {
                FinalizarTest();
            }
        }

            private Color GetRandomColor()
            {
                Color[] colors = new Color[]
                {
                Color.Red,
                Color.Blue,
                Color.Green,
                Color.Yellow,
                Color.Orange,
                };

                return colors[random.Next(colors.Length)];
            }

            private void panelColor_Click(object sender, EventArgs e)
            {
            if (!esperandoClick) return;

            esperandoClick = false;

            if (currentColor == Color.Red)
            {
                ActivarGlow();
                aciertos++;
                lblInfo.Text = "✔ Correcto";
            }
           
                else
                {
                    ActivarError();
                    errores++;

                    int vidasRestantes = erroresMaximos - errores;

                    if (vidasRestantes > 0)
                    {
                    lblInfo.Text = $"❤️ {erroresMaximos - errores}";
                }
                    else
                    {
                        lblInfo.Text = "💀 Fin del test";
                        FinalizarTest();
                        return;
                    }
                }

            lblScore.Text = $"Aciertos: {aciertos} | Errores: {errores}";
        }
        private void FinalizarTest()
        {
            timer.Stop();

            tiempoTotal = (DateTime.Now - inicioTest).TotalSeconds;
            timer.Stop();
            esperandoClick = false;

            GuardarResultado();
            MostrarResumen();
        }
        private void GuardarResultado()
        {
            string ruta = "resultados.csv";

            if (!File.Exists(ruta))
            {
                File.WriteAllText(ruta, "Fecha,Test,Aciertos,Errores,Omisiones,Tiempo\n");
            }

            string linea = $"{DateTime.Now},Atencion,{aciertos},{errores},{omisiones},{tiempoTotal:F2}";

            File.AppendAllText(ruta, linea + Environment.NewLine);
        }
        private void MostrarResumen()
        {
            int total = aciertos + errores + omisiones;
            double precision = total > 0 ? (double)aciertos / total * 100 : 0;

            MessageBox.Show(
                $"Test de Atención\n\n" +
                $"Aciertos: {aciertos}\n" +
                $"Errores: {errores}\n" +
                $"Omisiones: {omisiones}\n" +
                $"Precisión: {precision:F1}%\n" +
                $"Tiempo: {tiempoTotal:F2} segundos",
                "Resultado"
            );
        }

    }
}
