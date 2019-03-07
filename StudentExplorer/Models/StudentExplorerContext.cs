using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentExplorer.Models
{
    public class StudentExplorerContext : DbContext
    {
        public StudentExplorerContext(DbContextOptions<StudentExplorerContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
