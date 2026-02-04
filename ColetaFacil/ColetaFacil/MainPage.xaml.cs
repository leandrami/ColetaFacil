using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ColetaFacil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Mensagem
            //DisplayAlert("Informacao", "Vidro", "Fechar");

            // pergunta
            //if (await DisplayAlert("Informacao", "Vai se cadastrar?", "Não", "Sim") == false)
            //{
            //    await DisplayAlert("Informacao", "Executado", "Fechar");
            //}
            //else
            //{
            //    await DisplayAlert("Informacao", "Nao Executado", "Fechar");
            //}

        }

        private async void BtVidro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VidroPage());
        }
        private async void BtEletronicos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OleoPage1());
        }
        private async void BtOleo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EletronicosPage());
        }
        private async void BtBateria_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new bateriasPage());
        }
        private async void Btfornecedor_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProdutosPage());
        }
    }
}