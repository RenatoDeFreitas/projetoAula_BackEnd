﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace app_BackEnd_PUC.Models
{
    public class ApplicationDbContext : DbContext 
    {       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }
        public DbSet<veiculo> veiculos { get; set; }

    }
}
