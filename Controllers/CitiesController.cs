using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularASPNETCore2WebApiAuth.Data;
using AngularASPNETCore2WebApiAuth.Models.Entities;
using AngularASPNETCore2WebApiAuth.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularASPNETCore2WebApiAuth.Controllers
{
  [Route("api/[controller]")]
  [EnableCors("CorsPolicy")]
  [Authorize]
  public class CitiesController : Controller
  {
    private readonly ApplicationDbContext _context;

    public CitiesController(ApplicationDbContext context)
    {
      _context = context;
    }

    [HttpGet]
    public List<CityViewModel> GetAll()
    {
      List<CityViewModel> cityList = new List<CityViewModel>();
      var cities = _context.Cities.ToList();

      foreach (var city in cities)
      {
        city.Country = _context.Countries.Find(city.CountryId);
        city.Department = _context.Departments.Find(city.DepartmentId);

        var data = new CityViewModel
        {
          Id = city.CityId,
          Name = city.Name,
          CountryId = city.Country.CountryId,
          CountryName = city.Country.Name,
          DepartmentId = city.Department.DepartmentId,
          DepartmentName = city.Department.Name
        };
        cityList.Add(data);
      }

      return cityList;
    }

    [HttpGet("{id}", Name = "GetCity")]
    public IActionResult GetById(int id)
    {
      var item = _context.Cities.Find(id);
      if (item == null)
      {
        return NotFound();
      }
      item.Country = _context.Countries.Find(item.CountryId);
      item.Department = _context.Departments.Find(item.DepartmentId);
      var citiView = new CityViewModel
      {
        Id = item.CityId,
        Name = item.Name,
        CountryId = item.Country.CountryId,
        CountryName = item.Country.Name,
        DepartmentId = item.Department.DepartmentId,
        DepartmentName = item.Department.Name
      };

      return Ok(citiView);
    }

    [HttpPost]
    public IActionResult Create([FromBody] City city)
    {
      if (city == null)
      {
        return BadRequest();
      }

      _context.Cities.Add(city);
      _context.SaveChanges();

      return CreatedAtRoute("GetCity", new { id = city.DepartmentId }, city);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] City city)
    {
      if (city == null || city.CityId != id)
      {
        return BadRequest();
      }

      var cityUpdate = _context.Cities.Find(id);
      if (cityUpdate == null)
      {
        return NotFound();
      }

      cityUpdate.Name = city.Name;
      cityUpdate.CountryId = city.CountryId;
      cityUpdate.DepartmentId = city.DepartmentId;


      _context.Cities.Update(cityUpdate);
      _context.SaveChanges();
      return CreatedAtRoute("GetCity", new { id = cityUpdate.CityId }, cityUpdate);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      var city = _context.Cities.Find(id);
      if (city == null)
      {
        return NotFound();
      }

      _context.Cities.Remove(city);
      _context.SaveChanges();
      return NoContent();
    }
  }
}
