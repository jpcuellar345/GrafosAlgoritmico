using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafosAlgoritmico.Classes
{
    public class MatrizGrafo
    {
        private Nodo[,] matriz;
        private int tamanoNodo;
        private int espacioEntreNodo;

        public Nodo[,] Matriz { get => matriz; set => matriz = value; }
        public int TamanoNodo { get => tamanoNodo; set => tamanoNodo = value; }
        public int EspacioEntreNodo { get => espacioEntreNodo; set => espacioEntreNodo = value; }

        public MatrizGrafo(int fila, int columna, int tamanoNodo, int espacioEntreNodo, Color colorNodo1,  Color colorNodo2)
        {
            Matriz = new Nodo[fila, columna];
            this.TamanoNodo = tamanoNodo;
            this.EspacioEntreNodo = espacioEntreNodo;
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    if ((i + j)% 2 != 0)
                    {
                        Matriz[i, j] = new Nodo(0, 0, colorNodo1);
                    }

                    else
                    {
                        Matriz[i, j] = new Nodo(0, 0, colorNodo2); // Inicializar cada nodo con coordenadas por defecto
                    }
                }
            }
        }
        public void DibujarNodos(object sender, PaintEventArgs e, int diametroNodo, int distancia)
        {
            Graphics g = e.Graphics; // Obtener el objeto Graphics del evento
            Brush pincel; // Crear un pincel sólido para  círculos con relleno

            // Dibujar varios círculos en vairas línea horizontal dependiendo de la cantidad de filas de la matriz
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int colum = 0; colum < matriz.GetLength(1); colum++) // Dibujar círculos dependiendo de la cantidad de columnas de la matriz
                {
                    pincel = new SolidBrush(matriz[fila, colum].color);
                    int x = 20 + (diametroNodo + distancia) * colum; // Posición x calculada
                    int y = 10 + (diametroNodo + distancia) * fila; // Posición y constante para una línea horizontal
                    //g.DrawEllipse(lapiz, x, y, diametroNodo, diametroNodo); // Dibujar círculo
                    g.FillEllipse(pincel, x, y, diametroNodo, diametroNodo); //rellenar circulo
                    matriz[fila, colum].coordenaEjeX = x;
                    matriz[fila, colum].coordenaEjeY = y;
                    pincel.Dispose();
                }
            }

            // Liberar el recurso del lápiz
            //lapiz.Dispose();
        }

    }
}
