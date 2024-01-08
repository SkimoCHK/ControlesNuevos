using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ControlesNuevos.Vista;
using ControlesNuevos.VistaModelo;
using System.Windows.Input;

namespace ControlesNuevos.VistaModelo
{
    public class VMpage1 : BaseViewModel
    {

        public VMpage1(INavigation navigation)
        {
            Navigation = navigation;

        }

        public async Task Siguiente()
        {

            await Navigation.PushAsync(new Page2());

        }

        public ICommand ISiguientecommand => new Command(async () => await Siguiente());


    }
}
