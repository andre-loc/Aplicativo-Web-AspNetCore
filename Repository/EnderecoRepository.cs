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
    public class EnderecoRepository
    {
        private readonly ApplicationDbContext _context;

        public EnderecoRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Endereco>> Procurar(
            Expression<Func<Endereco, bool>> predicado)
        {
            return await _context.Endereco.AsNoTracking()
                .Where(predicado).ToListAsync();
        }

        public virtual async Task<Endereco> ObterPorId(Guid id)
        {
            return await _context.Endereco.FindAsync(id);
        }

        public async Task<List<Endereco>> ObterTodos()
        {
            return await _context.Endereco.ToListAsync();
        }

        public async Task Adicionar(Endereco entity)
        {
            _context.Endereco.Add(entity);
            await SaveChanges();
        }

        public async Task Atualizar(Endereco entity)
        {
            _context.Endereco.Update(entity);
            await SaveChanges();
        }

        public async Task Remover(int id)
        {
            _context.Endereco.Remove(new Endereco { Id = id });
            await SaveChanges();
        }

        private async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
