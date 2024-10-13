using Microsoft.EntityFrameworkCore;
using PARCIAL20200046.DOMAIN.Core.Entities;
using PARCIAL20200046.DOMAIN.Core.Interfaces;
using PARCIAL20200046.DOMAIN.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL20200046.DOMAIN.Infrastructure.Repositories
{
    public class AutoPartsRepository : IAutoPartsRepository
    {
        private readonly Parcial20240220200046Context _dbContext;

        public AutoPartsRepository(Parcial20240220200046Context dbcontext)
        {
            _dbContext = dbcontext;
        }

        public async Task<IEnumerable<AutoParts>> GetAutoParts()
        {
            var autoparts = await _dbContext.AutoParts.ToListAsync();
            return autoparts;
        }

        public async Task<AutoParts> GetAutoPartsbyId(int id)
        {
            var autoparts = await _dbContext
                            .AutoParts
                            .Where(a => a.Id == id)
                            .FirstOrDefaultAsync();
            return autoparts;
        }


        public async Task<int> Insert(AutoParts autoparts)
        {
            await _dbContext.AutoParts.AddAsync(autoparts);
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0 ? autoparts.Id : -1;
        }

        public async Task<bool> Update(AutoParts autoparts)
        {
            _dbContext.AutoParts.Update(autoparts);
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0;
        }
        public async Task<bool> Delete(int id)
        {
            var autoparts = await GetAutoPartsbyId(id);
            if (autoparts == null) return false;
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0;
        }






    }
}
