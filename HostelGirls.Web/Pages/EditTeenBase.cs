using AutoMapper;
using GirlsRanking.Girls;
using HostelGirls.Web.Models;
using HostelGirls.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelGirls.Web.Pages
{
    public class EditTeenBase : ComponentBase
    {
        [Inject]
        public ITeenService TeenService { get; set; }

        public Teen Teen { get; set; } = new Teen();

        async Task<Teen> Randomize(Teen teen)
        {
            var rand = new Random();
            var tempList = TeensStatic.Teens.ToList() ?? (await TeenService.GetTeens()).ToList();
            int teensCount = tempList.Count() - 1;


            var teensC = tempList[rand.Next(0, teensCount)];

            return teensC;
        }
        [Parameter]
        public string Id { get; set; }

        [Inject]
        public IMapper Mapper { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Teen = await TeenService.GetTeen(int.Parse(Id));
            //Teen = (Teen)await TeenService.GetTeens();
            
        }

        protected async Task HandleValidSubmit()
        {
            
            var result = await TeenService.UpdateTeen(Teen);
            
            if(result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }
        

        //protected async Task NewHandleValidSubmit()
        //{
        //    //var result = await TeenService.UpdateTeenNumber(TeenNumber);
        //    var result = await TeenService.UpdateNewTeen(Teen.Number);
        //    if (result != null)
        //    {
        //        NavigationManager.NavigateTo("/");
        //    }
        //}
    }
}
