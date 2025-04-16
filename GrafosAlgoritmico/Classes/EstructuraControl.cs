using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafosAlgoritmico.Classes
{
    internal class EstructuraControl
    {
        private static Stack<Nodo> pilaDeNodos;
        public static void AgregarRegistro(Nodo nuevoNodo, string textoNodo, int indexXDestino, int indexYDestino, string direccionDestino)
        {
            nuevoNodo.Valor = textoNodo; // Asignar un valor al Nodo
            nuevoNodo.indexXDestino = indexXDestino;
            nuevoNodo.indexYDestino = indexYDestino;
            nuevoNodo.direccionDestino = direccionDestino;
            pilaDeNodos.Push(nuevoNodo); // Agregar el Nodo a la pila

        }
        public static void EliminarRegistro()
        {
            if (pilaDeNodos.Count > 0)
            {
                Nodo nodoEliminado = pilaDeNodos.Pop(); // Quitar el nodo del tope de la pila
                MessageBox.Show($"Nodo removido: {nodoEliminado.Valor}");
            }
            else
            {
                MessageBox.Show("La pila está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
