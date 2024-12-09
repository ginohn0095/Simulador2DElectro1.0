using System;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace Simulador2DElectro1._0
{
    public partial class Form1 : Form
    {
        private CampoElectrico campo = new CampoElectrico();
        public Form1()
        {
            InitializeComponent();
          
        }

        private void btnAgregarCarga_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            float magnitud = (float)(rand.NextDouble() * 20 - 10);
            Vector2 posicion = new Vector2(rand.Next(50, pbCampo.Width - 50), rand.Next(50, pbCampo.Height - 50));
            campo.AgregarCarga(new Carga(posicion, magnitud));
            pbCampo.Invalidate(); // Redibuja el campo
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            campo = new CampoElectrico();
            pbCampo.Invalidate(); // Redibuja el campo limpio

        }
        private void pbCampo_Paint(object sender, PaintEventArgs e)
        {
            campo.Dibujar(e.Graphics, pbCampo.Size);
        }
    }
}
