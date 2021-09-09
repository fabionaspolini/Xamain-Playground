using System;
using System.Collections.Generic;
using Xamarin.Forms;
using DevExpress.Mvvm.CodeGenerators;
using System.Web;
using System.Linq;

namespace Forms.Models
{
    [GenerateViewModel]
    public partial class ProdutoDetalheViewModel : IQueryAttributable
    {
        [GenerateProperty]
        private ProdutoViewModel _produto;

        public void ApplyQueryAttributes(IDictionary<string, string> query)
        {
            var id = Convert.ToInt32(HttpUtility.UrlDecode(query["id"]));
            Produto = new ProdutosViewModel().Items.FirstOrDefault(x => x.Id == id);
        }
    }
}
