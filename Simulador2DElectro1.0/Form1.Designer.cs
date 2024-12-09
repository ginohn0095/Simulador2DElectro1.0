using System.Drawing;
using System.Windows.Forms;
using System;

namespace Simulador2DElectro1._0
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pbCampo;
        private Button btnAgregarCarga;
        private Button btnReiniciar;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.pbCampo = new PictureBox();
            this.btnAgregarCarga = new Button();
            this.btnReiniciar = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCampo)).BeginInit();
            this.SuspendLayout();

            // 
            // pbCampo
            // 
            this.pbCampo.Dock = DockStyle.Fill;
            this.pbCampo.BackColor = Color.White;
            this.pbCampo.Name = "pbCampo";
            this.pbCampo.Paint += new PaintEventHandler(this.pbCampo_Paint);

            // 
            // btnAgregarCarga
            // 
            this.btnAgregarCarga.Dock = DockStyle.Bottom;
            this.btnAgregarCarga.Text = "Agregar Carga";
            this.btnAgregarCarga.Name = "btnAgregarCarga";
            this.btnAgregarCarga.Click += new EventHandler(this.btnAgregarCarga_Click);

            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Dock = DockStyle.Bottom;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Click += new EventHandler(this.btnReiniciar_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbCampo);
            this.Controls.Add(this.btnAgregarCarga);
            this.Controls.Add(this.btnReiniciar);
            this.Name = "Form1";
            this.Text = "Simulador2DElectro1.0";
            this.WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbCampo)).EndInit();
            this.ResumeLayout(false);
        }



    }
}

