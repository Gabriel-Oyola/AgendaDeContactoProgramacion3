using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AgendaDeContactoProgramacion3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnAgenda.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new ListaContactos());
            };
        }
    }
}
