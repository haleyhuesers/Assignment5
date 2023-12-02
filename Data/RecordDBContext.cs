using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment5.Models;

namespace RecordDB.Data
{
    public class RecordDBContext : DbContext
    {
        public RecordDBContext (DbContextOptions<RecordDBContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment5.Models.Record> Record { get; set; } = default!;
    }
}
