﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafosAlgoritmico.Classes
{
    public class Nodo
    {
        private string valor;
        public Color colorValor;
        public int coordenaEjeX;
        public int coordenaEjeY;
        public Color colorNodo;
        public int indexXDestino;
        public int indexYDestino;
        public string direccionDestino;

        public Nodo(int coordenaEjeX, int coordenaEjeY, Color colorNodo)
        {
            this.valor = "";
            this.colorValor = colorNodo;
            this.coordenaEjeX = coordenaEjeX;
            this.coordenaEjeY = coordenaEjeY;
            this.colorNodo = colorNodo;
            indexXDestino = 0;
            indexYDestino = 0;
            direccionDestino = "";

        }

        public string Valor
        {
            get { return valor; }
            set
            {
                
                if (value.Length <0 || value.Length > 3)
                {
                    throw new ArgumentException("El nodo debe tener máximo 3 caracteres.");
                }
                else
                { this.valor = value; } // Asignar el valor si cumple la regla}
            }
        }

    }
}
