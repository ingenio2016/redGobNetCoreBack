using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularASPNETCore2WebApiAuth.ViewModels
{
  public class CoordinatorViewModel
  {
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Document { get; set; }

    public Nullable<DateTime> DateOfBirth { get; set; }

    public int CountryId { get; set; }

    public string CountryName { get; set; }

    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; }

    public int CityId { get; set; }

    public string CityName { get; set; }

    public int GenreId { get; set; }

    public string GenreName { get; set; }

    public string Address { get; set; }

    public string Latitude { get; set; }

    public string Longitude { get; set; }

    public string CellPhone { get; set; }

    public string Email { get; set; }

    public string Ocupation { get; set; }

    public int CommuneId { get; set; }

    public string Commune { get; set; }

    public string Association { get; set; }

    public string VotingPlace { get; set; }

    public int VotingPlaceId { get; set; }

    public string WorkPlace { get; set; }

    public string Observation { get; set; }

    public int UserId { get; set; }

    public string UserName { get; set; }
  }
}
