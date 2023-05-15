using GonzalezMartinParcial.DataAccess;
using GonzalezMartinParcial.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GonzalezMartinParcial.BussinnessLogic
{
    public class DepartamentoBL
    {
        private static DepartamentoBL _instance;

        public static DepartamentoBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DepartamentoBL();

                return _instance;
            }
        }

        public List<Departamento> SellecALL()
        {
            List<Departamento> result;
            try
            {
                result = DepartamentoDAL.Instance.SellectAll();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return result;
        }



        public bool Insert(Departamento entity)
        {
            bool result = false;
            try
            {
                result = DepartamentoDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return result;
        }

    }
}
