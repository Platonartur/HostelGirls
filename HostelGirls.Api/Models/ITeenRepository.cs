using GirlsRanking.Girls;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelGirls.Api.Models
{
    public interface ITeenRepository
    {
        Task<IEnumerable<Teen>> GetTeens();
        Task<Teen> GetTeen(int teenId);
        Task<Teen> UpdateTeen(Teen teen);
        
    }
}
