using Forms.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Forms
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("produtos/detalhes", typeof(ProdutoDetalhe));
        }
    }
}
