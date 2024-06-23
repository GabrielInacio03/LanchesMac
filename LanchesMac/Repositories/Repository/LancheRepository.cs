using LanchesMac.Data;
using LanchesMac.Models;
using LanchesMac.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Repositories.Repository
{
    public class LancheRepository : ILanche
    {
        private readonly LanchesMacContext _context;

        public LancheRepository(LanchesMacContext context)
        {
            this._context = context;
        }

        public IEnumerable<Lanche> lanches => _context.Lanche;

        public IEnumerable<Lanche> lanchesPreferidos => _context.Lanche;

        public Lanche GetId(long? id)
        {
            return _context.Lanche.FirstOrDefault(x => x.Id == id);
        }

        public void Save(Lanche lanche)
        {
            _context.Add(lanche);
            _context.SaveChangesAsync();
        }
        public void Update(Lanche lanche)
        {
            _context.Update(lanche);
            _context.SaveChangesAsync();
        }
        public void Remove(Lanche lanche)
        {
            _context.Remove(lanche);
            _context.SaveChangesAsync();
        }
    }
}
