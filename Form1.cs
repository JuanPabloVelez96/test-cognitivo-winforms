using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Juego
{
    public partial class InicioApp : System.Windows.Forms.Form
    {
        int nivel = 1;
        int errores = 0;

        DateTime inicioTest;
        int tiempoTotal = 0; // en segundos

        string tipoTestActual = "";
        
        public InicioApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            Form2 test = new Form2();
            test.FormClosed += (s, args) => this.Show(); // 👈 clave
            test.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form3 test = new Form3();
            test.FormClosed += (s, args) => this.Show(); // 👈 clave
            test.Show();
            this.Hide();
        }
        public static class Resultados
        {
            public static int PuntajeMemoria { get; set; }
            public static int PuntajeAtencion { get; set; }
        }
    }
}
