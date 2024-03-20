using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public  class Pet
    {


        public int Id { get; set; }




        [Display(Name = "Nombre Mascota")]
        [MaxLength(50, ErrorMessage = "El {0} no puede tener más de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!")]
        public string Name { get; set; }



        [Display(Name = "Foto")]

        public string ImageUrl { get; set; }


        [Display(Name = "Raza")]
        [MaxLength(50, ErrorMessage = "El {0} no puede tener más de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!")]
        public string Race { get; set; }



        [Display(Name = "Fecha de nacimiento")]
        [Required(ErrorMessage = "Este campo es obligatorio!")]

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]

        public DateTime Born { get; set; }


        [Display(Name = "Observaciones")]
        public string Remarks { get; set; }


        //Recibe foránea de PetType
        public PetType PetType { get; set; }

        //Recibe foránea de Owner 

        public Owner Owner { get; set; }


        //Envía llave foránea
        public ICollection<History> History { get; set; }


    }
}
