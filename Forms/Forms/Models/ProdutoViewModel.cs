using System.ComponentModel;
using DevExpress.Mvvm.CodeGenerators;

namespace Forms.Models
{
    [GenerateViewModel]
    public partial class ProdutoViewModel
    {
        [GenerateProperty]
        private int id;

        [GenerateProperty]
        private string nome;

        public ProdutoViewModel()
        {
        }

        public ProdutoViewModel(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
    }
}
