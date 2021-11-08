using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP02
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        async void btnEstiloPadrão(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EstiloPadraoPage());
        }

        async void btnEstiloDinamico(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EstiloDinamicoPage());
        }

        async void btnEventTriggers(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EstiloEventTriggersPage());
        }

        async void btnViewSimples(object sender, EventArgs e)
        {
         
            await Navigation.PushAsync(new ViewSimplesStaticPage());
        }
        async void btnParamsHomePage(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new ParamsHomePage());
        }

        async void btnProdutoForm(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new ProdutoFormPage());
        }
        
    }
}
