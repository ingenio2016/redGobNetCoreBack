using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularASPNETCore2WebApiAuth.Models.Entities
{
  public class UserInRole
  {
    public int UserInRoleId { get; set; }
    public int UserId { get; set; }
    public string RoleName { get; set; }
  }
}
