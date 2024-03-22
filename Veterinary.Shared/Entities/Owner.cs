using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class Owner
    {
 
        public int Id { get; set; }

        [Display(Name="Documento de identidad")]
        [MaxLength(13,ErrorMessage ="El {0} no puede tener más de {1} caracteres")]
        [Required(ErrorMessage ="Este campo es obligatorio!")]
        public string Document { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El {0} no puede tener más de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!")]

        public string FirstName { get; set; }

        [Display(Name = "Apellido")]
        [MaxLength(50, ErrorMessage = "El {0} no puede tener más de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!")]
        public string LastName { get; set; }


        [Display(Name = "Teléfono")]
        [MaxLength(10, ErrorMessage = "El {0} no puede tener más de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!")]
        public string  FixedPhone { get; set; }

        [Display(Name = "Móvil")]
        [MaxLength(10, ErrorMessage = "El {0} no puede tener más de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!")]
        public string CellPhone { get; set; }

        [Display(Name = "Email")]
        [MaxLength(50, ErrorMessage = "El {0} no puede tener más de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!")]
        [EmailAddress(ErrorMessage ="Email inválido")]
        public string Email { get; set; }

        [Display(Name = "Dirección")]
        [MaxLength(100, ErrorMessage = "El {0} no puede tener más de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!")]

        public string Address { get; set; }


        public string FullName => $"{FirstName}{LastName}";

        public string FullWithDocument => $"{FirstName}{LastName}-{Document}";

        public ICollection<Agenda> Agendas { get; set; }


    }
}
