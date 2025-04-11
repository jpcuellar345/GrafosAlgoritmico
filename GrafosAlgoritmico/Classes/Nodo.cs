using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafosAlgoritmico.Classes
{
    public class Nodo
    {
        public string valor;
        public int coordenaEjeX;
        public int coordenaEjeY;
        public Color color;


        public Nodo(int coordenaEjeX, int coordenaEjeY, Color color)
        {
            this.valor = "";
            this.coordenaEjeX = coordenaEjeX;
            this.coordenaEjeY = coordenaEjeY;
            this.color = color;
        }

        public string Valor
        {
            get { return valor; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 3) // Verificar que tenga exactamente 3 caracteres
                {
                    throw new ArgumentException("El nodo debe tener maximo 3 caracteres.");
                }
                this.valor = value; // Asignar si cumple con la regla
            }
        }
    }
}
