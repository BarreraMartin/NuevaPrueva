using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GonzalezMartinParcial.Entities
{
    public class Municipio
    {

        [Key]
        public int MunicipioId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int DepartamentoId { get; set; }
        public virtual Departamento Departamentos { get; set; }
    }
}
