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
        private int[] puntosNodoA = [0, 0];
        private int[] puntosNodoB = [0, 0];
        public Nodo[,] Nodos { get => nodos; set => nodos = value; }
        public int[] PuntosPartida { get => puntosPartida; set => puntosPartida = value; }
        public int[] PuntosNodoA { get => puntosNodoA; set => puntosNodoA = value; }
        public int[] PuntosNodoB { get => puntosNodoB; set => puntosNodoB = value; }

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

                    // Actualizar las coordenadas del cada nodo de la matriz Nodods
                    Nodos[fila, colum].coordenaEjeX = x;
                    Nodos[fila, colum].coordenaEjeY = y;
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
                PuntosNodoA = [puntosPartida[0], puntosPartida[1]];
            }
            else
            {
                throw new ArgumentException("Se sobrepasó el rango de la matriz"); // Lanzar excepción si los índices están fuera de rango
            }
        }

        public void SeleccionarSiguientNodo(Color original, Color nuevoColor, int aumentF, int aumentC, string texto)
        {
            // Calcular los índices del siguiente nodo
            int nuevaFila = PuntosNodoA[0] + aumentF;
            int nuevaColumna = PuntosNodoA[1] + aumentC;

            // Validar si se intenta seleccionar el nodo de partida
            // Verificar si se selecciona el mismo nodo que el actual
            if (puntosPartida[0] == nuevaFila && puntosPartida[1] == nuevaColumna)
            {
                throw new ArgumentException($"No se puede usar el mismo nodo en la posición [{PuntosNodoB[0] + 1}, {PuntosNodoB[1] + 1}].");
            }
            else if (nuevaFila < 0 || nuevaColumna < 0 ||
            nuevaFila >= Nodos.GetLength(0) || nuevaColumna >= Nodos.GetLength(1))
            {
                throw new ArgumentException($"Se sobrepasó el rango de la matriz.");
            }
            if ((puntosPartida[0] == 0 && puntosPartida[0] == 0 && PuntosNodoA[0] == 0 && PuntosNodoA[1] == 0 && Nodos[nuevaFila, nuevaColumna].Valor == "P1")
                || (Nodos[nuevaFila - aumentF, nuevaColumna - aumentC].Valor == "P1" && aumentF == 1 && aumentC == 1)) //para que me salte automaticamente a otro nodo si el punto de partida comienza en el primer nodo
            { //esto es para que no me reinicie el color y valor del nodo de partida, en el caso de que el nodo partida este en [0,0]
                PuntosNodoB[0] = nuevaFila;
                PuntosNodoB[1] = nuevaColumna;
                Nodos[PuntosNodoB[0], PuntosNodoB[1]].colorNodo = nuevoColor; // Cambiar el color del nuevo nodo
                Nodos[PuntosNodoB[0], PuntosNodoB[1]].colorValor = original;
                Nodos[PuntosNodoB[0], PuntosNodoB[1]].Valor = texto; // Asignar el texto al nuevo nodo
            }
            else
            {
                Nodos[PuntosNodoB[0], PuntosNodoB[1]].colorNodo = original;
                Nodos[PuntosNodoB[0], PuntosNodoB[1]].colorValor = original;
                Nodos[PuntosNodoB[0], PuntosNodoB[1]].Valor = ""; // Limpiar el texto del nodo actual


                // Validar que los nuevos índices estén dentro del rango
                // Actualizar el nodo al nuevo punto
                PuntosNodoB[0] = nuevaFila;
                PuntosNodoB[1] = nuevaColumna;
                Nodos[PuntosNodoB[0], PuntosNodoB[1]].colorNodo = nuevoColor; // Cambiar el color del nuevo nodo
                Nodos[PuntosNodoB[0], PuntosNodoB[1]].colorValor = original;
                Nodos[PuntosNodoB[0], PuntosNodoB[1]].Valor = texto; // Asignar el texto al nuevo nodo
            }
        }
        public void ReiniciarPuntosNodoB() //
        {
            PuntosNodoA = PuntosNodoB;
            puntosNodoB = [0, 0];
            //no veo la necesidad de reiniciar los puntosNodoB, ya que eso se encargara el metodo seleccionarSigueinte punto
        }
    }
}
