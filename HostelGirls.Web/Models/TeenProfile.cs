using AutoMapper;
using GirlsRanking.Girls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelGirls.Web.Models
{
    public class TeenProfile : Profile
    {
        public TeenProfile()
        {
            CreateMap<Teen, EditTeenModel>();
            CreateMap<EditTeenModel, Teen>();
        }
    }
}
