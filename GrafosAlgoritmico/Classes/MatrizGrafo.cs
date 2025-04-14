using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafosAlgoritmico.Classes
{
    public class MatrizGrafo
    {
        private Nodo[,] nodos;

        public Nodo[,] Nodos { get => nodos; set => nodos = value; }

        public void CrearMatriz(int fila, int columna, int tamanoNodo, int espacioEntreNodo, Color colorNodo1)
        {
            Nodos = new Nodo[fila, columna];
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Nodos[i, j] = new Nodo(0, 0, colorNodo1);
                }
            }
        }
        public void DibujarNodos(object sender, PaintEventArgs e, int diametroNodo, int distancia)
        {
            if (Nodos == null)
            {
                throw new InvalidOperationException("La matriz de nodos no ha sido inicializada.");
            }
            Graphics g = e.Graphics; // Obtener el objeto Graphics del evento
            // Dibujar varios círculos en vairas línea horizontal dependiendo de la cantidad de filas de la nodos
            for (int fila = 0; fila < Nodos.GetLength(0); fila++)
            {
                for (int colum = 0; colum < Nodos.GetLength(1); colum++) // Dibujar círculos dependiendo de la cantidad de columnas de la nodos
                {
                    using (Brush pincel = new SolidBrush(Nodos[fila, colum].color))
                    {
                        int x = 20 + (diametroNodo + distancia) * colum; // Posición x calculada
                        int y = 10 + (diametroNodo + distancia) * fila; // Posición y constante para una línea horizontal
                                                                        //g.DrawEllipse(lapiz, x, y, diametroNodo, diametroNodo); // Dibujar círculo
                        g.FillEllipse(pincel, x, y, diametroNodo, diametroNodo); //rellenar circulo
                        Nodos[fila, colum].coordenaEjeX = x;
                        Nodos[fila, colum].coordenaEjeY = y;
                    }
                }
            }
        }

    }
}
