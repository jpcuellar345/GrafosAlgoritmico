using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private int[] puntos = [0, 0];
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
            pilaDeNodos = new Stack<Nodo>();
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
            Font font = new Font("Arial", 10, FontStyle.Bold); // Fuente para el texto

            // Dibujar nodos en forma de círculos dependiendo de la posición y dimensiones especificadas
            for (int fila = 0; fila < Nodos.GetLength(0); fila++)
            {
                for (int colum = 0; colum < Nodos.GetLength(1); colum++)
                {
                    Nodo nodo = Nodos[fila, colum]; // Obtener el nodo actual
                    int x = 20 + (diametroNodo + distancia) * colum; // Calcular posición X
                    int y = 10 + (diametroNodo + distancia) * fila; // Calcular posición Y

                    // Dibujar el círculo del nodo
                    using (Brush pincelNodo = new SolidBrush(nodo.colorNodo)) // Usar el color específico del nodo
                    {
                        g.FillEllipse(pincelNodo, x, y, diametroNodo, diametroNodo); // Dibujar círculo relleno
                    }

                    // Obtener el texto del nodo
                    string textoNodo = Nodos[fila, colum].Valor;

                    // Calcular tamaño y posición del texto
                    SizeF tamañoTexto = g.MeasureString(textoNodo, font); // Medir dimensiones del texto
                    float textoX = x + (diametroNodo - tamañoTexto.Width) / 2; // Centrar horizontalmente
                    float textoY = y + (diametroNodo - tamañoTexto.Height) / 2; // Centrar verticalmente

                    // Dibujar el texto centrado
                    using (Brush pincelTexto = new SolidBrush(nodo.colorValor)) // Usar el color del texto especificado
                    {
                        g.DrawString(textoNodo, font, pincelTexto, textoX, textoY); // Dibujar texto
                    }

                    // Actualizar las coordenadas del nodo
                    nodo.coordenaEjeX = x;
                    nodo.coordenaEjeY = y;
                }
            }
        }

        //public void CrearLineaNodos(PaintEventArgs e, Color colorArista, int x1, int y1, int x2, int y2)
        //{
        //    // Crear el objeto Graphics
        //    Graphics g = e.Graphics;

        //    // Especificar el color de la línea
        //    Pen pen = new Pen(colorArista, 2); // Color rojo y grosor de 2px

        //    // Dibujar la línea
        //    g.DrawLine(pen, x1, y1, x2, y2);

        //    // Liberar recursos
        //    pen.Dispose();
        //}

        // Método para cambiar el punto de partida
        public void SeleccionarPuntoPartida(Color original, Color nuevoColor, int aumentF, int aumentC)
        {
            // Validar que la matriz esté inicializada
            if (Nodos == null)
            {
                throw new InvalidOperationException("La matriz de nodos no ha sido inicializada."); // Lanzar excepción si no está inicializada
            }
            Nodos[PuntosPartida[0], PuntosPartida[1]].colorNodo = original; //devolver al estado

            // Calcular nuevos índices para el punto de partida
            int nuevaFila = PuntosPartida[0] + aumentF;
            int nuevaColumna = PuntosPartida[1] + aumentC;

            // Validar los nuevos índices
            if (nuevaFila >= 0 && nuevaColumna >= 0 &&
                nuevaFila < Nodos.GetLength(0) && nuevaColumna < Nodos.GetLength(1))
            {
                // Actualizar el punto de partida
                PuntosPartida[0] = nuevaFila;
                PuntosPartida[1] = nuevaColumna;

                // Cambiar el color del nuevo nodo
                Nodos[PuntosPartida[0], PuntosPartida[1]].colorNodo = nuevoColor;
                Nodos[PuntosPartida[0], PuntosPartida[1]].colorValor = original;
                Nodos[PuntosPartida[0], PuntosPartida[1]].Valor = "P1";
            }
            else
            {
                throw new ArgumentException("Se sobrepasó el rango de la matriz"); // Lanzar excepción si los índices están fuera de rango
            }
        }

        public void SeleccionarSiguientNodo(Color original, Color nuevoColor, int aumentF, int aumentC, string texto)
        {
            // Validar que la matriz esté inicializada
            if (Nodos == null)
            {
                throw new InvalidOperationException("La matriz de nodos no ha sido inicializada."); // Lanzar excepción si no está inicializada
            }

            // Calcular los índices del siguiente nodo
            int nuevaFila = puntos[0] + aumentF;
            int nuevaColumna = puntos[1] + aumentC;

            // Validar si se intenta seleccionar el nodo de partida
            if (Nodos[nuevaFila, nuevaColumna].Valor == "P1")
            {
                // Mover automáticamente a la siguiente fila si los índices están dentro del rango

                nuevaColumna += 1; // Saltar a la siguiente fila
            }
            else
            { // Restaurar el nodo actual a su estado original
                Nodos[puntos[0], puntos[1]].colorNodo = original;
                Nodos[puntos[0], puntos[1]].colorValor = original;
                Nodos[puntos[0], puntos[1]].Valor = ""; // Limpiar el texto del nodo actual
            }

            // Validar que los nuevos índices estén dentro del rango
            if (nuevaFila < 0 || nuevaColumna < 0 ||
            nuevaFila >= Nodos.GetLength(0) || nuevaColumna >= Nodos.GetLength(1))
            {
                throw new ArgumentException($"Se sobrepasó el rango de la matriz: [{nuevaFila}, {nuevaColumna}].");
            }

            // Verificar si se selecciona el mismo nodo que el actual
            if (puntos[0] == nuevaFila && puntos[1] == nuevaColumna)
            {
                throw new ArgumentException($"No se puede usar el mismo nodo en la posición [{puntos[0] + 1}, {puntos[1] + 1}].");
            }



            // Actualizar el nodo al nuevo punto
            puntos[0] = nuevaFila;
            puntos[1] = nuevaColumna;
            Nodos[puntos[0], puntos[1]].colorNodo = nuevoColor; // Cambiar el color del nuevo nodo
            Nodos[puntos[0], puntos[1]].colorValor = original;
            Nodos[puntos[0], puntos[1]].Valor = texto; // Asignar el texto al nuevo nodo
        }
    }
}
