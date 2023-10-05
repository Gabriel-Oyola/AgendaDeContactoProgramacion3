using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaDeContactoProgramacion3
{
  
    public partial class ContactPage : ContentPage
    {
        public ContactPage(Contacto contacto)
        {
            InitializeComponent();
            BindingContext = contacto; 

        }
    }
}