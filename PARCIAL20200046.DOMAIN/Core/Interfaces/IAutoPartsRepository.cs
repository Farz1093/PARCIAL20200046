using PARCIAL20200046.DOMAIN.Core.Entities;

namespace PARCIAL20200046.DOMAIN.Core.Interfaces
{
    public interface IAutoPartsRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<AutoParts>> GetAutoParts();
        Task<AutoParts> GetAutoPartsbyId(int id);
        Task<int> Insert(AutoParts autoparts);
        Task<bool> Update(AutoParts autoparts);
    }
}