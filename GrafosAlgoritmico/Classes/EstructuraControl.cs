namespace GrafosAlgoritmico.Classes
{
    public class EstructuraControl
    {
        public static Stack<EstructuraControl> pilaDeNodos;
        private int numeroPaso;
        private int indexFilaOrigen;
        private int indexColumOrigen;
        private string direccionDestino;
        private int indexFilaDestino;
        private int indexColumDestino;
        private string valorNodoorigen;
        private string valorNodoDestino;

        public EstructuraControl(int numeroPaso, int indexFilaOrigen, int indexColumOrigen, string direccionDestino, int indexFilaDestino, int indexColumDestino, string valorNodoorigen, string valorNodoDestino)
        {
            this.IndexFilaDestino = indexFilaDestino;
            this.IndexColumDestino = indexColumDestino;
            this.IndexFilaOrigen = indexFilaOrigen;
            this.IndexColumOrigen = indexColumOrigen;
            this.DireccionDestino = direccionDestino;
            this.ValorNodo = valorNodoDestino;
            this.numeroPaso = numeroPaso;
            this.valorNodoorigen = valorNodoorigen;
        }

        public int IndexFilaDestino { get => indexFilaDestino; set => indexFilaDestino = value; }
        public int IndexColumDestino { get => indexColumDestino; set => indexColumDestino = value; }
        public int IndexFilaOrigen { get => indexFilaOrigen; set => indexFilaOrigen = value; }
        public int IndexColumOrigen { get => indexColumOrigen; set => indexColumOrigen = value; }
        public string DireccionDestino { get => direccionDestino; set => direccionDestino = value; }
        public string ValorNodo { get => valorNodoDestino; set => valorNodoDestino = value; }
        public int NumeroPaso { get => numeroPaso; set => numeroPaso = value; }
        public string ValorNodoorigen { get => valorNodoorigen; set => valorNodoorigen = value; }

        public static void IniciarStack()
        {
            pilaDeNodos = new Stack<EstructuraControl>();
        }
        public static void AgregarRegistro(EstructuraControl nuevoRegistro)
        {
            nuevoRegistro.NumeroPaso += pilaDeNodos.Count();
            pilaDeNodos.Push(nuevoRegistro); // Agregar el Nodo a la pila
        }
        public static void EliminarRegistro()
        {
            if (pilaDeNodos.Count > 0)
            {
                EstructuraControl registroEliminado = pilaDeNodos.Pop(); // Quitar el nodo del tope de la pila
                //MessageBox.Show($"Nodo removido: {nodoEliminado.Valor}");
            }
            else
            {
                MessageBox.Show("La pila está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
