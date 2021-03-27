using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Repos.Interfaces;
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
    }
}
