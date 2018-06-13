using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AngularASPNETCore2WebApiAuth.Models.Entities
{
  public class VotingPlace
  {
    [Key]
    public int VotingPlaceId { get; set; }

    public string Code { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    [MaxLength(50, ErrorMessage = "El campo {0} debe tener mínimo {1} caracteres")]
    public string Name { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar {0}")]
    public int CountryId { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar {0}")]
    public int DepartmentId { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar {0}")]
    public int CityId { get; set; }

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
