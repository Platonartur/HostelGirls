using GirlsRanking.Girls;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HostelGirls.Web.Services
{
    public class TeenService : ITeenService
    {
        private readonly HttpClient httpClient;

        public TeenService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Teen>> GetTeens()
        {
            return await httpClient.GetJsonAsync<Teen[]>("api/teens");
        }
    }
}
