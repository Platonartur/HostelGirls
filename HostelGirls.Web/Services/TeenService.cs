using GirlsRanking.Girls;
using HostelGirls.Web.Pages;
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

        public async Task<Teen> GetTeen(int id)
        {
            return await httpClient.GetJsonAsync<Teen>($"api/teens/{id}");
        }

        public async Task<IEnumerable<Teen>> GetTeens()
        {
            return await httpClient.GetJsonAsync<Teen[]>("api/teens");
        }

        public async Task<Teen> UpdateTeen(Teen updatedTeen)
        {
            return await httpClient.PutJsonAsync<Teen>("api/teens", updatedTeen);
        }

        //public async Task<Teen> UpdateNewTeen(int number)
        //{
        //    return await httpClient.PutJsonAsync<Teen>("api/teens", number);
        //}
        


        //public async Task<Teen> UpdateTeenNumber(int number)
        //{
        //    var rand = new Random();
        //    var tempList = TeensStatic.Teens.ToList() ?? (await GetTeens()).ToList();
        //    int teensCount = tempList.Count() - 1;


        //    var teensC = tempList[rand.Next(0, teensCount)];



        //    return await httpClient.PutJsonAsync<Teen>("api/teens", number);
        //}


    }
}
