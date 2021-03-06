﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Validation.Pages.Model
{
    public class CollegeContext : DbContext
    {

        public CollegeContext(DbContextOptions<CollegeContext> options)
            :base(options)
        { }


        public DbSet<Student> Students { get; set; }

    }
}
