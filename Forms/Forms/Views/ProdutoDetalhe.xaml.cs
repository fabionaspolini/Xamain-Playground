using Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProdutoDetalhe : ContentPage
    {
        private readonly ProdutoDetalheViewModel _context = new ProdutoDetalheViewModel();
        public ProdutoDetalhe()
        {
            InitializeComponent();
            BindingContext = _context;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _context.Produto.Nome = "Testeeeeeeeeeeeeee";
        }
    }
}