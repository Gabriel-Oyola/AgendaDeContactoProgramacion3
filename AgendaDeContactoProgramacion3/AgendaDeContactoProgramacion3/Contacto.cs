using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaDeContactoProgramacion3
{
    public class Contacto
    {

        public string Nombre { get; set; } 

        public string Telefono { get; set; } 

        public string Correo { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
