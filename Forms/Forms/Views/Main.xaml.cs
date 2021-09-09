using Forms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Forms.Views
{
    public partial class Main : ContentPage
    {
        public Main()
        {
            InitializeComponent();
            BindingContext = new ProdutoViewModel(1, "aaaa");
        }

        ProdutoViewModel Produto => (ProdutoViewModel)BindingContext;

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var teste = Produto.Nome;
            await DisplayAlert("Produto", $"Nome: {teste}", "OK");
        }

        private async void ListarProdutos_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//produtos");
        }
    }
}
