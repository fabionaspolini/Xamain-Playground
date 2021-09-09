using Forms.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Produtos : ContentPage
    {
        //public ObservableCollection<ProdutoViewModel> Items { get; set; }
        private readonly ProdutosViewModel _context = new ProdutosViewModel();

        public Produtos()
        {
            InitializeComponent();
            BindingContext = _context;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //collectionView.ItemsSource = Items;
        }

        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null && e.CurrentSelection.Any())
            {
                var selected = (ProdutoViewModel)e.CurrentSelection.FirstOrDefault();
                await Shell.Current.GoToAsync($"//produtos/detalhes?id={selected.Id}");
                ((CollectionView)sender).SelectedItem = null;
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Current Uri", $"Produto selecionado: {_context.SelectedItem?.Nome ?? "null"}", "OK");
        }
    }
}
