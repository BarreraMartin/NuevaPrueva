using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GonzalezMartinParcial.Entities.AppContext
{
    class AppDBContext: DbContext
    {
        public AppDBContext() : base("conn")
        {

        }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Municipio> Municipios { get; set; }



    }
}
