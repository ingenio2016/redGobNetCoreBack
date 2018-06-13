using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AngularASPNETCore2WebApiAuth.Models.Entities
{
  public class RedUser
  {
    [Key]
    public int RedUserId { get; set; }

    public string Name { get; set; }
  }
}
