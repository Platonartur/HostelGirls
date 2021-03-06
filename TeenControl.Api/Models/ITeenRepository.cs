using GirlsRanking.Girls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeenControl.Api.Models
{
    public interface ITeenRepository
    {
        Task<IEnumerable<Teen>> GetTeens();
        Task<Teen> GetTeen(int teenId);
        Task<Teen> UpdateTeen(Teen teen);

    }
}
