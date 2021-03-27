using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairdressingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricesControler : ControllerBase
    {
        private readonly IPricesRepository repository;

        public PricesControler(IPricesRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            try
            {
                return Ok(await repository.GetListAsync());

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            
        }
    }
}
