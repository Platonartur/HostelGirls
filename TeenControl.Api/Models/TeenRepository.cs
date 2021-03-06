using GirlsRanking.Girls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeenControl.Api.Models
{
    public class TeenRepository
    {
        private readonly AppDbContext appDbContext;

        public TeenRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Teen> GetEmployee(int teenId)
        {
            return await appDbContext.Teens
                .FirstOrDefaultAsync(e => e.TeenId == teenId);
        }

        public async Task<IEnumerable<Teen>> GetTeens()
        {
            return await appDbContext.Teens.ToListAsync();
        }


        public async Task<Teen> UpdateEmployee(Teen teen)
        {
            var result = await appDbContext.Teens
                .FirstOrDefaultAsync(e => e.TeenId == teen.TeenId);

            if (result != null)
            {
                result.Number = teen.Number;
                result.Id = teen.Id;
                result.Name = teen.Name;
                result.Img = teen.Img;
                result.ImgName = teen.ImgName;


                await appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }

    }
}
