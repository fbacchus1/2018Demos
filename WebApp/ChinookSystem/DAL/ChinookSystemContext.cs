using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using ChinookSystem.Entities;
using System.Data.Entity;


using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace ChinookSystem.DAL
{

    internal class ChinookSystemContext:DbContext
    {
        public ChinookSystemContext() : base("name=ChinookDB")
        {

        }
        public DbSet<Artist> Artists{ get; set; }
        public DbSet<Album>  Albums{get; set;


    }
    
}
