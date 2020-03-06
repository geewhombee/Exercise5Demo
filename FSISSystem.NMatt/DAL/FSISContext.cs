using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FSISSystem.NMatt;


namespace FSISSystem.NMatt.DAL
{
    internal class FSISContext : DbContext
    {
        public FSISContext() : base("")
        {
        }
        public DbSet<Region> Regions { get; set; }
        
    }
    
}
