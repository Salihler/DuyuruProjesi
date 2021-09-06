using System.Threading.Tasks;

namespace DuyuruProjesi.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit(); 
    }
}