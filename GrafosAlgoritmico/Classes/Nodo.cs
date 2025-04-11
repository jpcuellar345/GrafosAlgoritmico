using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafosAlgoritmico.Classes
{
    public class Nodo
    {
        private string valor;
        private int valorEjeX;
        private int valorEjeY;
        private string color;


        public Nodo(string valor, int valorEjeX, int valorEjeY, string color)
        {
            Valor = valor;
            ValorEjeX = valorEjeX;
            ValorEjeY = valorEjeY;
            Color = color;
        }

        public string Valor { get => valor; set => valor = value; }
        public int ValorEjeX { get => valorEjeX; set => valorEjeX = value; }
        public int ValorEjeY { get => valorEjeY; set => valorEjeY = value; }
        public string Color { get => color; set => color = value; }
    }
}
