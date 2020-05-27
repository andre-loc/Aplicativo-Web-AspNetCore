using System;
using System.Collections.Generic;

namespace ProdutosWeb.Models
{
    public partial class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int FornecedorId { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
    }
}
