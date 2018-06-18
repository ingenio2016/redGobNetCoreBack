using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularASPNETCore2WebApiAuth.Models.ApiModels
{
    public class BossApi
    {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Document { get; set; }
    public string DateOfBirth { get; set; }
    public int CountryId { get; set; }
    public int DepartmentId { get; set; }
    public int CityId { get; set; }
    public string Address { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public int CellPhone { get; set; }
    public string Email { get; set; }
    public string Ocupation { get; set; }
    public int CommuneId { get; set; }
    public string Association { get; set; }
    public int VotingPlaceId { get; set; }
    public string WorkPlace { get; set; }
    public string Observation { get; set; }
    public int UserId { get; set; }
  }
}
