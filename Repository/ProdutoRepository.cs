using System;
using Microsoft.EntityFrameworkCore;
using ProdutosWeb.Data;
using ProdutosWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProdutosWeb.Repository
{
    public class ProdutoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProdutoRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Produto>> Procurar(
            Expression<Func<Produto, bool>> predicado)
        {
            return await _context.Produto.AsNoTracking()
                .Where(predicado).ToListAsync();
        }

        public virtual async Task<Produto> ObterPorId(Guid id)
        {
            return await _context.Produto.FindAsync(id);
        }

        public async Task<List<Produto>> ObterTodos()
        {
            return await _context.Produto.ToListAsync();
        }

        public async Task Adicionar(Produto entity)
        {
            _context.Produto.Add(entity);
            await SaveChanges();
        }

        public async Task Atualizar(Produto entity)
        {
            _context.Produto.Update(entity);
            await SaveChanges();
        }

        public async Task Remover(int id)
        {
            _context.Produto.Remove(new Produto { Id = id });
            await SaveChanges();
        }

        private async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }
    }
}

