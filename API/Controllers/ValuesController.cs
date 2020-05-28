using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private DataContext _context; 

        public ValuesController(DataContext context)
        {
            _context = context; 
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Value>>> Get(int id)
        {
            var values = await _context.Values.FindAsync(id); 
            return Ok(values); 
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Value>>> Get()
        {
            var values = await _context.Values.ToListAsync(); 
            return Ok(values); 
        }

    }
}
