using GirlsRanking.Girls;
using HostelGirls.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelGirls.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeensController : ControllerBase
    {
        private readonly ITeenRepository teenRepository;
        

        public TeensController(ITeenRepository teenRepository)
        {
            this.teenRepository = teenRepository;
        }


        [HttpGet]
        public async Task<ActionResult> GetTeens()
        {
            try
            {
                return Ok(await teenRepository.GetTeens());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Teen>> GetTeen(int id)
        {
            try
            {
                var result = await teenRepository.GetTeen(id);

                if (result == null) return NotFound();

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        [HttpPut(/*"{id}"*/)]
        public async Task<ActionResult<Teen>> UpdateTeen(Teen teen)
        {
            try
            {              
                var teenToUpdate = await teenRepository.GetTeen(teen.TeenId);

                if (teenToUpdate == null)
                    return NotFound($"Employee with Id = {teen.TeenId} not found");

                return await teenRepository.UpdateTeen(teen);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }

        
    }
}
