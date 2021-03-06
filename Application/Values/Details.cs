using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Values
{
    public class Details
    {
        public class Query : IRequest<Value>
        {
            public long Id {get; set;}
        }

        public class Handler : IRequestHandler<Query, Value>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context; 
            }

            public async Task<Value> Handle(Query request, CancellationToken cancellationToken)
            {
                var value = await _context.Values.FindAsync(request.Id); 

                return value; 
            }

            // Task<Value> IRequestHandler<Query, Value>.Handle(Query request, CancellationToken cancellationToken)
            // {
            //     throw new NotImplementedException();
            // }
        }
        
    }
}