using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AgendaDeContactoProgramacion3
{
    public class GenerarContacto
    {
        private static List<string> ListaNombres = new List<string>
        {
            "Santiago", "Matías", "Martin"
        };

        private static List<string> ListaApellidos = new List<string>
        {
            "Moyano", "Errador", "Irusta"
        };  


        public static ObservableCollection<Contacto> CrearContactos()
        {
            var random = new Random(); 
            var Contactos = new ObservableCollection<Contacto>(); 
            
            for(int i = 0; i < 17; i++)
            {
                var nombres = ListaNombres[random.Next(ListaNombres.Count-1)];
                var apellidos = ListaApellidos[random.Next(ListaApellidos.Count-1)];

                var contacto = new Contacto
                {
                    Nombre = nombres + " " + apellidos, 
                    Telefono = GenerarTelefono(), 
                    Correo = nombres + apellidos + "@gmail.com"
                };

                Contactos.Add(contacto); 
            }

            return Contactos;  

        }

        private static string GenerarTelefono()
        {
            var random = new Random(); 
            StringBuilder telefono = new StringBuilder();
            telefono.Append("(351) 9");
            telefono.Append(random.Next(1000000, 9999999)); 
            return telefono.ToString(); 
        }
    }
}
