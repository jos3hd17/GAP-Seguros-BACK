using System;
using Microsoft.EntityFrameworkCore;

namespace policy_back
{
    
    public class ApiContext : DbContext
        {
            public ApiContext(DbContextOptions<ApiContext> options)
                : base(options)
            {
            }

            public DbSet<Models.Customer> Customer { get; set; }

            public DbSet<Models.Policy> Policy { get; set; }

            public DbSet<Models.Coverage> Coverage { get; set; }

    }
}


