using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParamsHomePage : ContentPage
    {
        public ParamsHomePage()
        {
            InitializeComponent();
        }

        async void bntDetalhe_Clicked(object sender, EventArgs e)
        {
            var contato = new Contato
            {
                Nome = Nome.Text,
                Idade = int.Parse(Idade.Text),
                Profissao = Profissao.Text,
                Pais = Pais.Text
            };
            var detalhePage = new DetalheViewPage();
            detalhePage.BindingContext = contato;
            await Navigation.PushAsync(detalhePage);
        }
    }
}