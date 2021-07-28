using Catalog.Repositories.Abstractions.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        public PingController(IRepositoryPropertyGroup repository)
        {

        }

        [HttpGet]
        public IActionResult Ping()
        {
            return Ok();
        }
    }
}
