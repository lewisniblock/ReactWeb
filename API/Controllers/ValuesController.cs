using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;
using Application.Values;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        // private DataContext _context; 
        private readonly IMediator _mediator; 

        public ValuesController(IMediator mediator)
        {
            _mediator = mediator; 
        }

        [HttpGet]
        public async Task<ActionResult<List<Value>>> List()
        {
            return await _mediator.Send(new List.Query()); 
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Value>> Details(long id)
        {
            return await _mediator.Send(new Details.Query{Id = id}); 
        }


        // public ValuesController(DataContext context)
        // {
        //     _context = context; 
        // }

        // [HttpGet("{id}")]
        // public async Task<ActionResult<IEnumerable<Value>>> Get(int id)
        // {
        //     var values = await _context.Values.FindAsync(id); 
        //     return Ok(values); 
        // }

        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<Value>>> Get()
        // {
        //     var values = await _context.Values.ToListAsync(); 
        //     return Ok(values); 
        // }

    }
}
