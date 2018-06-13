using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularASPNETCore2WebApiAuth.ViewModels
{
  public class VotingPlaceViewModel
  {
    public int Id { get; set; }

    public string Code { get; set; }

    public int CountryId { get; set; }

    public string CountryName { get; set; }

    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; }

    public int CityId { get; set; }

    public string CityName { get; set; }

    public string Name { get; set; }
  }
}
