using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AngularASPNETCore2WebApiAuth.Models.Entities
{
  public class City
  {
    [Key]
    public int CityId { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    [MaxLength(50, ErrorMessage = "El campo {0} debe tener mínimo {1} caracteres")]
    [Display(Name = "Nombre ciudad")]
    public string Name { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar {0}")]
    [Display(Name = "Departamento")]
    public int DepartmentId { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar {0}")]
    [Display(Name = "País")]
    public int CountryId { get; set; }

    public Country Country { get; set; }
    public Department Department { get; set; }

    public ICollection<User> Users { get; set; }
    public ICollection<Commune> Communes { get; set; }
    public ICollection<VotingPlace> VotingPlaces { get; set; }
    public ICollection<Boss> Bosses { get; set; }
    public ICollection<Link> Links { get; set; }
    public ICollection<Coordinator> Coordinators { get; set; }
    public ICollection<Leader> Leaders { get; set; }
    public ICollection<Voter> Voters { get; set; }


  }
}
