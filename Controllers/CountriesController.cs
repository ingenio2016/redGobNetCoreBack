using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AngularASPNETCore2WebApiAuth.Data;
using AngularASPNETCore2WebApiAuth.Models.Entities;
using AngularASPNETCore2WebApiAuth.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AngularASPNETCore2WebApiAuth.Controllers
{
  [Route("api/[controller]")]
  [Authorize]
  public class CountriesController : ControllerBase
  {
    private readonly ApplicationDbContext _context;

    public CountriesController(ApplicationDbContext context)
    {
      _context = context;
    }

    [HttpGet]
    public List<CountryViewModel> GetAll()
    {
      List<CountryViewModel> countryList = new List<CountryViewModel>();
      var countries = _context.Countries.ToList();

      foreach (var country in countries)
      {
        var data = new CountryViewModel
        {
          Id = country.CountryId,
          Name = country.Name
        };
        countryList.Add(data);
      }

      return countryList;
    }

    [HttpGet("{id}", Name = "GetCountry")]
    public IActionResult GetById(int id)
    {
      var item = _context.Countries.Find(id);
      if (item == null)
      {
        return NotFound();
      }

      var countryView = new CountryViewModel
      {
        Id = item.CountryId,
        Name = item.Name
      };

      return Ok(countryView);
    }

    [HttpPost]
    public IActionResult Create([FromBody] Country country)
    {
      if (country == null)
      {
        return BadRequest();
      }

      _context.Countries.Add(country);
      _context.SaveChanges();

      return CreatedAtRoute("GetCountry", new { id = country.CountryId }, country);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Country country)
    {
      if (country == null || country.CountryId != id)
      {
        return BadRequest();
      }

      var countryUpdate = _context.Countries.Find(id);
      if (countryUpdate == null)
      {
        return NotFound();
      }

      countryUpdate.Name = country.Name;
      

      _context.Countries.Update(countryUpdate);
      _context.SaveChanges();
      return CreatedAtRoute("GetCountry", new { id = countryUpdate.CountryId }, countryUpdate);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      var country = _context.Countries.Find(id);
      if (country == null)
      {
        return NotFound();
      }

      _context.Countries.Remove(country);
      _context.SaveChanges();
      return NoContent();
    }
  }
}
