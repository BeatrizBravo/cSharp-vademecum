using System;

namespace Objetos.Models
{
    public class Bebida
    {
        public string Name { get; set; }
        public int Cantidad { get; set; }

        public Bebida(string name, int cantidad)
        {
            Name = name;
            Cantidad = cantidad;
        }

        public void Beberse(int cantidad)
        {
            Cantidad -= cantidad;
        }
    }
}