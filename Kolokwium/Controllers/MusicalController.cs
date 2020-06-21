using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Kolokwium.Services;

namespace Kolokwium.Controllers
{
    [Route("api/musicans")]
    [ApiController]
    public class MusicalController : ControllerBase
    {
        private readonly IMusicalDbService _service;

        public MusicalController(IMusicalDbService service)
        {
            _service = service;
        }
        [HttpGet("{id}")]
        public IActionResult getMusician([FromQuery] int id)
        {
            try
            {
                var resp = _service.getMusician(id);
                return Ok(resp);
            }
            catch(Exception e)
            {
                return NotFound(e);
            }
        }
    }
}