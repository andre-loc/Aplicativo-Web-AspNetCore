using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;

namespace ProdutosWeb.Models
{
    public partial class Fornecedor
    {
        public Fornecedor()
        {
            Endereco = new HashSet<Endereco>();
            Produto = new HashSet<Produto>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Endereco> Endereco { get; set; }
        public virtual ICollection<Produto> Produto { get; set; }
    }
}
