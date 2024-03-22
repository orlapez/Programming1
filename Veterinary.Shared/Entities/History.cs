using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class History
    {
        public int Id { get; set; }


        [Display(Name = "Descripción")]
        [MaxLength(100, ErrorMessage = "El {0} no puede tener más de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!")]

        public string Description { get; set; }



        [Display(Name = "Fecha atención")]
        [Required(ErrorMessage = "Este campo es obligatorio!")]

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]

        public DateTime Date { get; set; }


        [Display(Name = "Observaciones")]
        public string Remarks { get; set; }



        [Display(Name = "Fecha Local")]
      
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateLocal=>Date.ToLocalTime();  


        public ServiceType ServiceTypes { get; set; }

        public Pet Pets { get; set; }


    }
}
