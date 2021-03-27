using GirlsRanking.Girls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelGirls.Web.Services
{
    public interface ITeenService
    {
        Task<IEnumerable<Teen>> GetTeens();
        Task<Teen> GetTeen(int id);
        Task<Teen> UpdateTeen(Teen updatedTeen);

        


        //Task<Teen> UpdateTeenNumber(int number);
    }
}

