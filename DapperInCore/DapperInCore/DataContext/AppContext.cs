using DapperInCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperInCore.DataContext
{
    public class AppContext:DbContext
    {
        public AppContext() { }
        public AppContext(DbContextOptions<AppContext> options) : base(options) { }

        public StudentDTO student { get; set; }
    }
}

