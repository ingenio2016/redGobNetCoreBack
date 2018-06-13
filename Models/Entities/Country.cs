using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AngularASPNETCore2WebApiAuth.Models.Entities
{
  public class Country
  {
    [Key]
    public int CountryId { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    [MaxLength(100, ErrorMessage = "El campo {0} debe tener mínimo {1} caracteres")]
    [Display(Name = "Nombre país")]
    public string Name { get; set; }

    public ICollection<Department> Departments { get; set; }
    public ICollection<City> Cities { get; set; }
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
