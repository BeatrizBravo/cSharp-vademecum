using System;

namespace Objetos.Models
{

    public class Orange : Bebida
    {
        // constructor de su padre y los parametros se los envia al padre y ya no hay que crear un constructor
        public Orange(int Cantidad, string Nombre="Child-Orange") : base(Nombre, Cantidad)
        {
        }

    }

}
