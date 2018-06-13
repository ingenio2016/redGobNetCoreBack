using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularASPNETCore2WebApiAuth.ViewModels
{
  public class DepartmentViewModel
  {
    public int Id { get; set; }
    public int CountryId { get; set; }
    public string CountryName { get; set; }
    public string Name { get; set; }
  }
}
