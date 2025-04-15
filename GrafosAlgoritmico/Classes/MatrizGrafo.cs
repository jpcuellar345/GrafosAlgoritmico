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
        private int[] puntosPartida = [0, 0]; // Coordenadas del punto de partida inicializado en (0,0)

        public Nodo[,] Nodos { get => nodos; set => nodos = value; }
        public int[] PuntosPartida { get => puntosPartida; set => puntosPartida = value; }

        // Método para inicializar la matriz de nodos
        public void CrearMatriz(int fila, int columna, int tamanoNodo, int espacioEntreNodo, Color colorNodo1)
        {
            // Crear matriz de nodos con las dimensiones especificadas
            Nodos = new Nodo[fila, columna];
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Nodos[i, j] = new Nodo(0, 0, colorNodo1); // Inicializar cada nodo con colorNodo1
                }
            }
        }

        // Método para dibujar los nodos en el formulario
        public void DibujarNodos(PaintEventArgs e, int diametroNodo, int distancia)
        {
            // Validar que la matriz esté inicializada
            if (Nodos == null)
            {
                throw new InvalidOperationException("La matriz de nodos no ha sido inicializada."); // Lanzar excepción si no está inicializada
            }

            Graphics g = e.Graphics; // Obtener el objeto Graphics del evento Paint

            // Dibujar nodos en forma de círculos dependiendo de la posición y dimensiones especificadas
            for (int fila = 0; fila < Nodos.GetLength(0); fila++)
            {
                for (int colum = 0; colum < Nodos.GetLength(1); colum++)
                {
                    using (Brush pincel = new SolidBrush(Nodos[fila, colum].color)) // Usar el color específico de cada nodo
                    {
                        int x = 20 + (diametroNodo + distancia) * colum; // Calcular posición X
                        int y = 10 + (diametroNodo + distancia) * fila; // Calcular posición Y
                        g.FillEllipse(pincel, x, y, diametroNodo, diametroNodo); // Dibujar círculo relleno
                        Nodos[fila, colum].coordenaEjeX = x; // Guardar coordenada X del nodo
                        Nodos[fila, colum].coordenaEjeY = y; // Guardar coordenada Y del nodo
                    }
                }
            }
        }

        // Método para establecer el color del punto de partida
        public void FijarPuntoPartida(Color nuevoColor)
        {
            // Validar que la matriz esté inicializada y que el punto de partida esté dentro del rango
            if (Nodos == null)
            {
                throw new InvalidOperationException("La matriz de nodos no ha sido inicializada."); // Lanzar excepción si no está inicializada
            }

            if (PuntosPartida[0] >= 0 && PuntosPartida[1] >= 0 &&
                PuntosPartida[0] < Nodos.GetLength(0) && PuntosPartida[1] < Nodos.GetLength(1))
            {
                Nodos[PuntosPartida[0], PuntosPartida[1]].color = nuevoColor; // Establecer nuevo color al nodo en el punto de partida
            }
            else
            {
                throw new ArgumentException("El punto de partida está fuera del rango de la matriz."); // Lanzar excepción si los índices están fuera de rango
            }
        }

        // Método para cambiar el punto de partida
        public void CambiarPuntoPartida(Color original, Color nuevoColor, int aumentF, int aumentC)
        {
            // Validar que la matriz esté inicializada
            if (Nodos == null)
            {
                throw new InvalidOperationException("La matriz de nodos no ha sido inicializada."); // Lanzar excepción si no está inicializada
            }

            // Restaurar el color del nodo actual al color original
            Nodos[PuntosPartida[0], PuntosPartida[1]].color = original;

            // Calcular nuevos índices para el punto de partida
            int nuevaFila = PuntosPartida[0] + aumentF;
            int nuevaColumna = PuntosPartida[1] + aumentC;

            // Validar los nuevos índices
            if (nuevaFila >= 0 && nuevaColumna >= 0 &&
                nuevaFila < Nodos.GetLength(0) && nuevaColumna < Nodos.GetLength(1))
            {
                PuntosPartida[0] = nuevaFila; // Actualizar fila del punto de partida
                PuntosPartida[1] = nuevaColumna; // Actualizar columna del punto de partida
                Nodos[PuntosPartida[0], PuntosPartida[1]].color = nuevoColor; // Cambiar el color del nuevo nodo
            }
            else
            {
                Nodos[PuntosPartida[0], PuntosPartida[1]].color = nuevoColor;
                throw new ArgumentException("Se sobre paso el rango de la matriz."); // Lanzar excepción si los índices están fuera de rango
            }
        }



    }
}
