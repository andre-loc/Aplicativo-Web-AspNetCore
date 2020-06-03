using System;
using System.Collections.Generic;
using ProdutosWeb.Data;

namespace ProdutosWeb.Models
{
    public partial class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }
        public int FornecedorId { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
    }
}
