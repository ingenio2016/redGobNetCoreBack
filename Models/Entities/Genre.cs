using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AngularASPNETCore2WebApiAuth.Models.Entities
{
  public class Genre
  {
    [Key]
    public int GenreId { get; set; }
    public string Name { get; set; }

    public ICollection<User> Users { get; set; }
    public ICollection<Boss> Bosses { get; set; }
    public ICollection<Link> Links { get; set; }
    public ICollection<Coordinator> Coordinators { get; set; }
    public ICollection<Leader> Leaders { get; set; }
    public ICollection<Voter> Voters { get; set; }
  }
}
