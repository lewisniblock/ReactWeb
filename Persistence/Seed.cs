using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if(!context.Activities.Any())
            {
                var activites = new List<Activity>
                {
                    new Activity
                    {
                        Title = "Test 231",
                        Description = "test description"
                    }
                };
            }
        }
    }
}