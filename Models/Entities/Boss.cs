using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AngularASPNETCore2WebApiAuth.Models.Entities
{
  public class Boss  {
    [Key]
    public int BossId { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    public string Document { get; set; }

    public Nullable<DateTime> DateOfBirth { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    public int CountryId { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    public int DepartmentId { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    public int CityId { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    public string Address { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    public string Latitude { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    public string Longitude { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    public string CellPhone { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    public string Ocupation { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    public int CommuneId { get; set; }

    public string Association { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    public int VotingPlaceId { get; set; }

    public string WorkPlace { get; set; }

    public string Observation { get; set; }


    [Required(ErrorMessage = "El campo {0} es requerido")]
    public int UserId { get; set; }
    public Country Country { get; set; }
    public Department Department { get; set; }
    public City City { get; set; }
    public Commune Commune { get; set; }
    public VotingPlace VotingPlace { get; set; }
    public User User { get; set; }

  }
}
