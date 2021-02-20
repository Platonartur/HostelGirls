using GirlsRanking.Girls;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HostelGirls.Web.Pages
{
    public class GirlsListBase:ComponentBase
    {
        protected string DisplayTime()
        {
            return $"Рейтинг на: {DateTime.Now.ToShortDateString()}";
        }

        /*protected List<Teen> teens { get; set; }        
        protected async override Task OnInitializedAsync()
        {           
            teens = new List<Teen>()
        {            
            new Teen()
            {
                Id = "https://vk.com/die_young_my_baby",
                Name = "Anya Shelk",
                Img = "images/TopTelka.jpg"
            },
            new Teen()
            {
                Id = "https://vk.com/id412379471",
                Name = "Aurora Redfield",
                Img = "images/Amaliya.jpg"
            },
            new Teen()
            {
                Id = "https://vk.com/lellap",
                Name = "Elena Popovskikh",
                Img = "images/Sofia_kolotilina.jpg"
            }
        };
        }  
        */
        public IEnumerable<Teen> teens { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadTeens);

        }
        protected void LoadTeens()
        {
            teens = new List<Teen>
            {
                new Teen()
                {
                    Number = 0,
                    Id = "https://vk.com/id412379471",
                    Name = "Aurora Redfield",
                    Img = "images/Amaliya.jpg",
                    ImgName = "images/Amaliya.jpg".Remove("images/Amaliya.jpg".Length-4)
                },
                new Teen()
                {
                    Number = 0,
                    Id = "https://vk.com/lellap",
                    Name = "Elena Popovskikh",
                    Img = "images/Sofia_kolotilina.jpg",
                    ImgName = "images/Sofia_kolotilina.jpg".Remove("images/Sofia_kolotilina.jpg".Length-4)
                },
                new Teen()
                {
                     Number = 0,
                     Id = "https://vk.com/die_young_my_baby",
                     Name = "Anya Shelk",
                     Img = "images/TopTelka.jpg",
                     ImgName = "images/TopTelka.jpg".Remove("images/TopTelka.jpg".Length-4)
                },
                new Teen()
                {
                    Number = 0,
                    Id="",
                    Img="images/DaryaAfanasieva.jpg",
                    ImgName="images/DaryaAfanasieva.jpg".Remove("images/DaryaAfanasieva.jpg".Length-4)
                }
            };
        }    

        private void Voting()
        {         
            //var rand = new Random();
            //int v = rand.Next(teens.SelectMany);
            //Random r = new Random();
            //var result1 = teens;
            //teens.Push(3);
            //for (int i = 0; i < teens.Count(); i++)
            //{

            //}
            //if teens.Contains(){ }
            //var randomNumbers = result1.Select(r);
            //foreach(var teen in teens)
            //{
            //    if (teen.Number = rand.NextBytes())
            //    {

            //    }
            //    var random = new Random();
            //    teen.Number = random.OrderBy(order => random.Next);
            //}
            //foreach (int i in Enumerable.Range(0, 9).OrderBy(teens => r.Next()))
            //{
            //    Console.WriteLine(teens); 
            //}

        }
    }
    public class ForVoting
    {

    }
}
