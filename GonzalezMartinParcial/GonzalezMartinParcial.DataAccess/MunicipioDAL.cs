using GonzalezMartinParcial.Entities;
using GonzalezMartinParcial.Entities.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GonzalezMartinParcial.DataAccess
{
    public class MunicipioDAL
    {
        private static MunicipioDAL _instance;

        public static MunicipioDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MunicipioDAL();
                }
                return _instance;

            }


        }

        public List<Municipio> SellectAll()
        {
            List<Municipio> result = null;
            using (AppDBContext _context = new AppDBContext())
            {
                result = _context.Municipios.Include(x => x.Departamentos).ToList();
            }

            return result;


        }


        public bool Insert(Municipio entity)
        {
            bool result = false;
            using (AppDBContext _context = new AppDBContext())
            {
                var query = _context.Municipios.FirstOrDefault(x => x.Nombre.Equals(entity.Nombre));
                if (query == null)
                {
                    _context.Municipios.Add(entity);
                    result = _context.SaveChanges() > 0;

                }

                return result;

            }

        }
    }
}
