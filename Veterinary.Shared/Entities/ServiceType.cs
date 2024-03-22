using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
  public class ServiceType
    {


        public int Id { get; set; }


        [Display(Name = "Tipo de Servicio")]
        [MaxLength(50, ErrorMessage = "El {0} no puede tener más de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!")]
        public string Name { get; set; }



        public ICollection<History> Histories { get; set; }


    }
}
