using GonzalezMartinParcial.Entities;
using GonzalezMartinParcial.Entities.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GonzalezMartinParcial.DataAccess
{
    public class DepartamentoDAL
    {

        private static DepartamentoDAL _instance;

        public static DepartamentoDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DepartamentoDAL();
                }
                return _instance;

            }


        }

        public List<Departamento> SellectAll()
        {
            List<Departamento> result = null;
            using (AppDBContext _context = new AppDBContext())
            {
                result = _context.Departamentos.ToList();
            }

            return result;


        }

       
        public bool Insert(Departamento entity)
        {
            bool result = false;
            using (AppDBContext _context = new AppDBContext())
            {
                var query = _context.Departamentos.FirstOrDefault(x => x.Nombre.Equals(entity.Nombre));
                if (query == null)
                {
                    _context.Departamentos.Add(entity);
                    result = _context.SaveChanges() > 0;

                }

                return result;

            }

        }

    }
}
