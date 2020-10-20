using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public class OdeToFood1DbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
