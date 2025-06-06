﻿namespace GrafosAlgoritmico.Classes
{
    public class MatrizGrafo
    {
        private Nodo[,] nodos;
        private int[] puntosPartida = [0, 0]; // Coordenadas del punto de partida inicializado en (0,0)
        private int[] puntosNodoA = [0, 0];
        private int[] puntosNodoB = [0, 0];
        private string valorPuntoPartida = "1°";
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
        public void DibujarNodos(PaintEventArgs e, int diametroNodo, int distancia, Color colorMatriz)
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
                    using (Pen bordeNodo = new Pen(colorMatriz, 2)) // Color negro con grosor de 2px
                    {
                        g.DrawEllipse(bordeNodo, x, y, diametroNodo, diametroNodo);
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

        public void SeleccionarPuntoPartida(Color original, Color nuevoColor, int aumentF, int aumentC)
        {
            // Validar que la matriz esté inicializada
            if (Nodos == null)
            {
                throw new InvalidOperationException("La matriz de nodos no ha sido inicializada."); // Lanzar excepción si no está inicializada
            }
            Nodos[PuntosPartida[0], PuntosPartida[1]].colorNodo = original; //devolver al estado
            Nodos[PuntosPartida[0], PuntosPartida[1]].Valor = string.Empty;

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
                Nodos[PuntosPartida[0], PuntosPartida[1]].Valor = valorPuntoPartida;
                PuntosNodoA = [puntosPartida[0], puntosPartida[1]];


                if (PuntosNodoA[0] == 0 && PuntosNodoA[1] == 0 && Nodos[puntosNodoA[0], puntosNodoA[0]].Valor == valorPuntoPartida)
                {//para solucionar error de que pasa si incio el punto de partida esta en el nodo[0,0]
                    PuntosNodoB = [0, 1];
                }

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
            if (puntosPartida[0] == 0 && puntosPartida[0] == 0 && PuntosNodoA[0] == 0 && PuntosNodoA[1] == 0 && Nodos[nuevaFila, nuevaColumna].Valor == valorPuntoPartida)
            { //esto es para que no me reinicie el color y valor del nodo de partida, en el caso de que el nodo partida este en [0,0]
                PuntosNodoB[0] = nuevaFila;
                PuntosNodoB[1] = nuevaColumna;
                if (Nodos[PuntosNodoB[0], PuntosNodoB[1]].Valor.Length != 0)
                {
                    PuntosNodoB[0] -= nuevaFila;
                    PuntosNodoB[1] -= nuevaColumna;
                    throw new ArgumentException("El nodo ya tiene un valor.");
                }
                Nodos[PuntosNodoB[0], PuntosNodoB[1]].colorNodo = nuevoColor; // Cambiar el color del nuevo nodo
                Nodos[PuntosNodoB[0], PuntosNodoB[1]].colorValor = original;
                Nodos[PuntosNodoB[0], PuntosNodoB[1]].Valor = texto; // Asignar el texto al nuevo nodo
            }
            else
            {
                Nodos[PuntosNodoB[0], PuntosNodoB[1]].colorNodo = original;
                Nodos[PuntosNodoB[0], PuntosNodoB[1]].colorValor = original;
                Nodos[PuntosNodoB[0], PuntosNodoB[1]].Valor = string.Empty; // Limpiar el texto del nodo actual


                // Validar que los nuevos índices estén dentro del rango
                // Actualizar el nodo al nuevo punto
                PuntosNodoB[0] = nuevaFila;
                PuntosNodoB[1] = nuevaColumna;
                if (Nodos[PuntosNodoB[0], PuntosNodoB[1]].Valor.Length != 0)
                {
                    PuntosNodoB[0] -= nuevaFila;
                    PuntosNodoB[1] -= nuevaColumna;
                    throw new ArgumentException("El nodo ya tiene un valor.");
                }
                Nodos[PuntosNodoB[0], PuntosNodoB[1]].colorNodo = nuevoColor; // Cambiar el color del nuevo nodo
                Nodos[PuntosNodoB[0], PuntosNodoB[1]].colorValor = original;
                Nodos[PuntosNodoB[0], PuntosNodoB[1]].Valor = texto; // Asignar el texto al nuevo nodo
            }
        }
        public void ReiniciarPuntosNodoB() //
        {
            try
            {
                PuntosNodoA = PuntosNodoB;
                PuntosNodoB = BuscarCoincidenciaNodo("");
            }
            catch
            {
                MessageBox.Show("No se encontró nodo disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int[] BuscarCoincidenciaNodo(string palabraClave)
        {
            int[] RangoDeIndex = { -1, 0, 1 };

            for (int fila = 0; fila < RangoDeIndex.Length; fila++)
            {
                for (int columna = 0; columna < RangoDeIndex.Length; columna++)
                {
                    int nuevoFila = PuntosNodoA[0] + RangoDeIndex[fila];
                    int nuevoColumna = PuntosNodoA[1] + RangoDeIndex[columna];

                    // Validamos si la posición está dentro de los límites antes de acceder a nodos
                    if (nuevoFila >= 0 && nuevoFila < nodos.GetLength(0) &&
                        nuevoColumna >= 0 && nuevoColumna < nodos.GetLength(1) &&
                        nodos[nuevoFila, nuevoColumna].Valor == palabraClave)
                    {
                        return [nuevoFila, nuevoColumna];
                    }
                }
            }

            // Si no se encuentra un nodo disponible, lanzamos la excepción directamente
            throw new ArgumentException("No se encontró el nodo.");
        }




        public void DesahacerNodoB(Color original)
        {
            if (EstructuraControl.pilaDeNodos.Count > 0)
            {
                EstructuraControl RegistroEliminar = EstructuraControl.GetUltimoRegistro();
                int indexF = RegistroEliminar.IndexFilaDestino;
                int indexC = RegistroEliminar.IndexColumDestino;

                Nodos[indexF, indexC].colorNodo = original;
                Nodos[indexF, indexC].colorValor = original;
                Nodos[indexF, indexC].Valor = string.Empty;


                indexF = RegistroEliminar.IndexFilaOrigen;
                indexC = RegistroEliminar.IndexColumOrigen;
                puntosNodoA = [indexF, indexC];
            }
            else if (EstructuraControl.pilaDeNodos.Count == 0)
            {
                int indexF = puntosPartida[0];
                int indexC = puntosPartida[1];
                Nodos[indexF, indexC].colorNodo = original;
                Nodos[indexF, indexC].colorValor = original;
                Nodos[indexF, indexC].Valor = string.Empty;
                puntosPartida = [0, 0];
            }
        }
    }
}
