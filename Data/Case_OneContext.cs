using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Case_One.Models
{
    public class Case_OneContext : DbContext
    {
        public Case_OneContext (DbContextOptions<Case_OneContext> options)
            : base(options)
        {
        }

    }
}
