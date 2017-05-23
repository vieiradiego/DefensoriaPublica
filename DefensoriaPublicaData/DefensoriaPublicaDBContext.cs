using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefensoriaPublicaData
{
    public class DefensoriaPublicaDBContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
