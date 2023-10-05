using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Xamarin.Forms;

namespace AgendaDeContactoProgramacion3
{
    public class ListaContactos : MasterDetailPage 
    {
        public ListaContactos()
        {
            var lista = new ListView();
            lista.ItemsSource = GenerarContacto.CrearContactos().OrderBy(X => X.Nombre);
            lista.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    Detail = new ContactPage(e.SelectedItem as Contacto); 
                    IsPresented = false;
                }
            };

            Master = new ContentPage
            {
                Title = "Contactos",
                Content = lista

            };

            Detail = new ContactPage(GenerarContacto.CrearContactos().First());


        }
    }
}
