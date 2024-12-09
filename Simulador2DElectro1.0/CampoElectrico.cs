using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace Simulador2DElectro1._0
{
    internal class CampoElectrico
    {
        public List<Carga> Cargas { get; private set; } = new List<Carga>();
        public float Escala { get; set; } = 10.0f;

        public void AgregarCarga(Carga carga)
        {
            Cargas.Add(carga);
        }

        public Vector2 CalcularCampo(Vector2 punto)
        {
            Vector2 campoTotal = Vector2.Zero;
            foreach (var carga in Cargas)
            {
                Vector2 r = punto - carga.Posicion;
                float distancia = r.Length();
                if (distancia == 0) continue;

                campoTotal += carga.Magnitud / (distancia * distancia) * Vector2.Normalize(r);
            }
            return campoTotal;
        }

        public void Dibujar(Graphics g, Size area)
        {
            for (int x = 0; x < area.Width; x += 10)
            {
                for (int y = 0; y < area.Height; y += 10)
                {
                    Vector2 punto = new Vector2(x, y);
                    Vector2 campo = CalcularCampo(punto);
                    campo *= Escala;

                    g.DrawLine(Pens.Blue, x, y, x + campo.X, y + campo.Y);
                }
            }

            foreach (var carga in Cargas)
            {
                Brush brush = carga.Magnitud > 0 ? Brushes.Red : Brushes.Blue;
                g.FillEllipse(brush, carga.Posicion.X - 5, carga.Posicion.Y - 5, 10, 10);
            }
        }
    }
}

