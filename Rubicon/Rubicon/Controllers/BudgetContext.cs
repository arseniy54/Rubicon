using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rubicon.Models;

namespace Rubicon.Controllers
{
    public class BudgetContext : DbContext 
    {
        public BudgetContext(DbContextOptions<BudgetContext> options)
            :base(options)
            {
            }
        public DbSet<Budget> Budgets { get; set; }
    }
            
       
}

