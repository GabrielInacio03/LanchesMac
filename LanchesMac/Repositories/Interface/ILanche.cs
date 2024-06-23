using LanchesMac.Models;

namespace LanchesMac.Repositories.Interface
{
    public interface ILanche
    {
        IEnumerable<Lanche> lanches { get; }
        IEnumerable<Lanche> lanchesPreferidos { get; }
        public void Save(Lanche lanche);
        public void Update(Lanche lanche);
        public void Remove(Lanche lanche);
        public Lanche GetId(long? id);
    }
}
