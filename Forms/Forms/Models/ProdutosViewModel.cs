using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Forms.Models
{
    public class ProdutosViewModel
    {
        public ProdutosViewModel()
        {
            Items = new ObservableCollection<ProdutoViewModel>
            {
                new (1, "Prego"),
                new (2, "Parafuso"),
                new (3, "Teste")
            };
        }

        public ObservableCollection<ProdutoViewModel> Items { get; set; }
        public ProdutoViewModel SelectedItem { get; set; }
    }
}
