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
    public class ContatoRepository
    {
        private readonly ApplicationDbContext _context;

        public ContatoRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Contato>> Procurar(
            Expression<Func<Contato, bool>> predicado)
        {
            return await _context.Contato.AsNoTracking()
                .Where(predicado).ToListAsync();
        }

        public virtual async Task<Contato> ObterPorId(Guid id)
        {
            return await _context.Contato.FindAsync(id);
        }

        public async Task<List<Contato>> ObterTodos()
        {
            return await _context.Contato.ToListAsync();
        }

        public async Task Adicionar(Contato entity)
        {
            _context.Contato.Add(entity);
            await SaveChanges();
        }

        public async Task Atualizar(Contato entity)
        {
            _context.Contato.Update(entity);
            await SaveChanges();
        }

        public async Task Remover(int id)
        {
            _context.Contato.Remove(new Contato { Id = id });
            await SaveChanges();
        }

        private async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
