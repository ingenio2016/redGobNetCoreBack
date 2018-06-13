using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AngularASPNETCore2WebApiAuth.Models.Entities
{
  public class User
  {
    [Key]
    public int UserId { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    [MaxLength(80, ErrorMessage = "El campo {0} debe tener mínimo {1} caracteres")]
    [Display(Name = "Nombre")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    [MaxLength(80, ErrorMessage = "El campo {0} debe tener mínimo {1} caracteres")]
    [Display(Name = "Apellido")]
    public string LastName { get; set; }

    [MaxLength(20, ErrorMessage = "El campo {0} debe tener mínimo {1} caracteres")]
    [DataType(DataType.PhoneNumber)]
    [Display(Name = "Teléfono")]
    public string Phone { get; set; }

    [MaxLength(300, ErrorMessage = "El campo {0} debe tener mínimo {1} caracteres")]
    [Display(Name = "Dirección")]
    public string Address { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar {0}")]
    [Display(Name = "Género")]
    public int GenreId { get; set; }


    [DataType(DataType.ImageUrl)]
    [Display(Name = "Foto")]
    public string Photo { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar {0}")]
    public int CountryId { get; set; }


    [Required(ErrorMessage = "El campo {0} es requerido")]
    [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar {0}")]
    public int DepartmentId { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar {0}")]
    public int CityId { get; set; }

    [Display(Name = "Nombre Completo")]
    public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    [DataType(DataType.EmailAddress)]
    [MaxLength(250, ErrorMessage = "El campo {0} debe tener mínimo {1} caracteres")]
    [Display(Name = "Correo electrónico")]
    public string UserName { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }

    public Genre Genre { get; set; }

    public Country Country { get; set; }

    public Department Department { get; set; }

    public City City { get; set; }

    public ICollection<Boss> Bosses { get; set; }

    public ICollection<Link> Links { get; set; }

    public ICollection<Coordinator> Coordinators { get; set; }

    public ICollection<Leader> Leaders { get; set; }

    public ICollection<Voter> Voters { get; set; }


  }
}
