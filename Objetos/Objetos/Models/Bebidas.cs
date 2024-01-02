using System;

namespace Objetos.Models
{
    public class Bebida
    {
        public string Name { get; set; }
        public int Cantidad { get; set; }

        public Bebida(string name, int cantidad)
        {
            this.Name = name;
            this.Cantidad = cantidad;
        }

        public void Beberse(int cuantoBebio)
        {
            this.Cantidad -= cuantoBebio;
            
;
        }
    }
}