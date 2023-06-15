﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using salesWebMvc.Models;

namespace salesWebMvc.Data
{
    public class salesWebMvcContext : DbContext
    {
        public salesWebMvcContext (DbContextOptions<salesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<salesWebMvc.Models.Department> Department { get; set; } = default!;
    }

}
