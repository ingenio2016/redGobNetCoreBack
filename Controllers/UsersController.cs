using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularASPNETCore2WebApiAuth.Data;
using AngularASPNETCore2WebApiAuth.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularASPNETCore2WebApiAuth.Controllers
{
  [Route("api/[controller]")]
  [Authorize]
  public class UsersController : Controller
  {
    private readonly ApplicationDbContext _context;

    public UsersController(ApplicationDbContext context)
    {
      _context = context;
    }

    [HttpGet]
    public List<UserView> GetAll()
    {
      List<UserView> userList = new List<UserView>();
      var users = _context.DataUsers.ToList();

      foreach (var user in users)
      {
        user.Country = _context.Countries.Find(user.CountryId);
        user.Department = _context.Departments.Find(user.DepartmentId);
        user.City = _context.Cities.Find(user.CityId);
        user.Genre = _context.Genres.Find(user.GenreId);
        var UserRole = _context.UserInRoles.Where(u => u.UserId == user.UserId).FirstOrDefault();
        var data = new UserView
        {
          Id = user.UserId,
          FirstName = user.FirstName,
          LastName = user.LastName,
          Address = user.Address,
          CountryId = user.Country.CountryId,
          CountryName = user.Country.Name,
          DepartmentId = user.Department.DepartmentId,
          DepartmentName = user.Department.Name,
          CityId = user.City.CityId,
          CityName = user.City.Name,
          GenreId = user.Genre.GenreId,
          GenreName = user.Genre.Name,
          Phone = user.Phone,
          FullName = user.FullName,
          UserEmail = user.UserName          
        };

        if(UserRole != null)
        {
          data.Role = UserRole.RoleName;
        }

        userList.Add(data);
      }

      return userList;
    }

    [HttpGet("{id}", Name = "GetUser")]
    public IActionResult GetById(int id)
    {
      var user = _context.DataUsers.Find(id);
      if (user == null)
      {
        return NotFound();
      }

      user.Country = _context.Countries.Find(user.CountryId);
      user.Department = _context.Departments.Find(user.DepartmentId);
      user.City = _context.Cities.Find(user.CityId);
      user.Genre = _context.Genres.Find(user.GenreId);
      var UserRole = _context.UserInRoles.Where(u => u.UserId == user.UserId).FirstOrDefault();
      var userView = new UserView
      {
        Id = user.UserId,
        FirstName = user.FirstName,
        LastName = user.LastName,
        Address = user.Address,
        CountryId = user.Country.CountryId,
        CountryName = user.Country.Name,
        DepartmentId = user.Department.DepartmentId,
        DepartmentName = user.Department.Name,
        CityId = user.City.CityId,
        CityName = user.City.Name,
        GenreId = user.Genre.GenreId,
        GenreName = user.Genre.Name,
        Phone = user.Phone,
        FullName = user.FullName,
        UserEmail = user.UserName
      };

      if(UserRole != null)
      {
        userView.Role = UserRole.RoleName;
      }

      return Ok(userView);
    }
  }
}
