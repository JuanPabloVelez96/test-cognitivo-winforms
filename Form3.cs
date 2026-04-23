using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Juego
{


   

        public partial class Form3 : System.Windows.Forms.Form
        {
        int nivel = 1;
        int errores = 0;
        
        DateTime inicioTest;
        int tiempoTotal = 0;

        string tipoTestActual = "Memoria";
        List<Color> secuencia = new List<Color>();
            List<Color> respuestaUsuario = new List<Color>();

            Random random = new Random();

        public bool turnoJugador { get; private set; }

        public Form3()
        {
            InitializeComponent();
                 IniciarTestMemoria();
           
        }
      
        private void IniciarTestMemoria()
        {
            int nivel = 1;
            int errores = 0;

            int tiempoTotal = 0;

            string tipoTestActual = "";
            inicioTest = DateTime.Now;

        }

        private void GenerarSecuencia(int longitud)
            {
                Color[] colores = { Color.Red, Color.Blue, Color.Green, Color.Yellow };

                for (int i = 0; i < longitud; i++)
                {
                    secuencia.Add(colores[random.Next(colores.Length)]);
                }
            }

            private async Task MostrarSecuencia()
            {
                foreach (Color color in secuencia)
                {
                    pnlColor.BackColor = color;
                    await Task.Delay(700);

                    pnlColor.BackColor = Color.White;
                    await Task.Delay(90);
                }
            }

            private void RegistrarClick(Color color)
            {
            {
                if (!turnoJugador) return;

                respuestaUsuario.Add(color);

                if (respuestaUsuario.Count == secuencia.Count)
                {
                    VerificarRespuesta();
                }
            }
            
            }
        private async void btnStart_Click(object sender, EventArgs e)
        {
            turnoJugador = false;

            secuencia.Clear();
            respuestaUsuario.Clear();

            lblNivel.Text = "Nivel 1";

            lblInfo2.Text = "Memorizá la secuencia...";

            GenerarSecuencia(3);

            await MostrarSecuencia();

            turnoJugador = true;

            lblInfo2.Text = "Repetí la secuencia";
        }
        
        


        private async void btnRojo_ClickAsync(object sender, EventArgs e)
            {
            this.BackColor = Color.Red;
            await Task.Delay(200);
            this.BackColor = Color.White;

            RegistrarClick(Color.Red);
        }

        private async void VerificarRespuesta()
        {
            bool correcto = true;
            nivel++;
                    lblNivel.Text = "Nivel " + nivel;

            for (int i = 0; i < secuencia.Count; i++)
            {
                if (secuencia[i] != respuestaUsuario[i])
                {
                    
                    correcto = false;
                    ;
                    break;
                }
            }

            if (correcto)
            {
                lblInfo2.Text = "✔ Correcto";

                await Task.Delay(100);

                respuestaUsuario.Clear();

                GenerarSecuencia(1); // suma un color

                await MostrarSecuencia();
            }
            else
            {
                lblInfo2.Text = "❌ Incorrecto - Fin del juego";
                errores++;
                turnoJugador = false;
                FinalizarTest();

            }
        }



        private async void btnAzul_ClickAsync(object sender, EventArgs e)
            {
            this.BackColor = Color.Blue;
            await Task.Delay(200);
            this.BackColor = Color.White;

            RegistrarClick(Color.Blue);
        }

            private async void btnVerde_ClickAsync(object sender, EventArgs e)
            {
            this.BackColor = Color.Green;
            await Task.Delay(200);
            this.BackColor = Color.White;

            RegistrarClick(Color.Green);
        }

            private async void btnAmarillo_ClickAsync(object sender, EventArgs e)
            {
            this.BackColor = Color.Yellow;
            await Task.Delay(200);
            this.BackColor = Color.White;

            RegistrarClick(Color.Yellow);
        }
        

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void pnlColor_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FinalizarTest()
        {
            if (inicioTest == DateTime.MinValue)
            {
                MessageBox.Show("Error: el tiempo no fue inicializado.");
                return;
            }

            tiempoTotal = (int)(DateTime.Now - inicioTest).TotalSeconds;

            GuardarResultado();
            MostrarResumen();
        }

        private void GuardarResultado()
        {
            string ruta = "resultados.csv";

            // encabezado si no existe
            if (!File.Exists(ruta))
            {
                File.WriteAllText(ruta, "Fecha,Test,Nivel,Errores,Tiempo\n");
            }

            string linea = $"{DateTime.Now},{tipoTestActual},{nivel},{errores},{tiempoTotal}";

            File.AppendAllText(ruta, linea + Environment.NewLine);

        }

        private void MostrarResumen()
        {
            MessageBox.Show(
                $"Test: {tipoTestActual}\n" +
                $"Nivel alcanzado: {nivel}\n" +
                $"Errores: {errores}\n" +
                $"Tiempo: {tiempoTotal} segundos",
                "Resultado"
            );
        }
    }
    }




