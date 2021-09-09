using FormsTabbed.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FormsTabbed.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}