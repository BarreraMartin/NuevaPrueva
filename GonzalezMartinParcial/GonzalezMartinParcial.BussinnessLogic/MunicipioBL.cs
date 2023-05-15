using GonzalezMartinParcial.DataAccess;
using GonzalezMartinParcial.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GonzalezMartinParcial.BussinnessLogic
{
    public  class MunicipioBL
    {
        private static MunicipioBL _instance;

        public static MunicipioBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MunicipioBL();

                return _instance;
            }
        }

        public List<Municipio> SellecALL()
        {
            List<Municipio> result;
            try
            {
                result = MunicipioDAL.Instance.SellectAll();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return result;
        }



        public bool Insert(Municipio entity)
        {
            bool result = false;
            try
            {
                result = MunicipioDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return result;
        }
    }
}
