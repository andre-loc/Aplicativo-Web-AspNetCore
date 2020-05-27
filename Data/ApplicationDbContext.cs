using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProdutosWeb.Models;

namespace ProdutosWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Fornecedor> Fornecedor { get; set; }

    }
}
