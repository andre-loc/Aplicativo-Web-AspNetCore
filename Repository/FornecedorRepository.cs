using System;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ProdutosWeb.Data;
using ProdutosWeb.Models;

namespace ProdutosWeb.Repository
{
    public class FornecedorRepository
    {
        private readonly ApplicationDbContext _context;

        public FornecedorRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Fornecedor>> Procurar(
            Expression<Func<Fornecedor, bool>> predicado)
        {
            return await _context.Fornecedor.AsNoTracking()
                .Where(predicado).ToListAsync();
        }

        public virtual async Task<Fornecedor> ObterPorId(Guid id)
        {
            return await _context.Fornecedor.FindAsync(id);
        }

        public async Task<List<Fornecedor>> ObterTodos()
        {
            return await _context.Fornecedor.ToListAsync();
        }

        public async Task Adicionar(Fornecedor entity)
        {
            _context.Fornecedor.Add(entity);
            await SaveChanges();
        }

        public async Task Atualizar(Fornecedor entity)
        {
            _context.Fornecedor.Update(entity);
            await SaveChanges();
        }

        public async Task Remover(int id)
        {
            _context.Fornecedor.Remove(new Fornecedor { Id = id });
            await SaveChanges();
        }

        private async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }
    }
}

