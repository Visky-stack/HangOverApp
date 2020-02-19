using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HangOver.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HangOver.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var values = await _context.Values.ToListAsync();

            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(value => value.Id == id);

            return Ok(value);
        }
    }
}
