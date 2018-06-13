using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularASPNETCore2WebApiAuth.Data;
using AngularASPNETCore2WebApiAuth.Models.Entities;
using AngularASPNETCore2WebApiAuth.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularASPNETCore2WebApiAuth.Controllers
{
  [Route("api/[controller]")]
  [Authorize]
  public class VotingPlacesController : Controller
  {
    private readonly ApplicationDbContext _context;
    public VotingPlacesController(ApplicationDbContext context)
    {
      _context = context;
    }

    [HttpGet]
    public List<VotingPlaceViewModel> GetAll()
    {
      List<VotingPlaceViewModel> votingPlacesList = new List<VotingPlaceViewModel>();
      var votingPlaces = _context.VotingPlaces.ToList();

      foreach (var votingPlace in votingPlaces)
      {
        votingPlace.Country = _context.Countries.Find(votingPlace.CountryId);
        votingPlace.Department = _context.Departments.Find(votingPlace.DepartmentId);
        votingPlace.City = _context.Cities.Find(votingPlace.CityId);
        var data = new VotingPlaceViewModel
        {
          Id = votingPlace.VotingPlaceId,
          Code = votingPlace.Code,
          Name = votingPlace.Name,
          CountryId = votingPlace.Country.CountryId,
          CountryName = votingPlace.Country.Name,
          DepartmentId = votingPlace.Department.DepartmentId,
          DepartmentName = votingPlace.Department.Name,
          CityId = votingPlace.City.CityId,
          CityName = votingPlace.City.Name
        };
        votingPlacesList.Add(data);
      }

      return votingPlacesList;
    }

    [HttpGet("{id}", Name = "GetVotingPlace")]
    public IActionResult GetById(int id)
    {
      var votingPlace = _context.VotingPlaces.Find(id);
      if (votingPlace == null)
      {
        return NotFound();
      }

      votingPlace.Country = _context.Countries.Find(votingPlace.CountryId);
      votingPlace.Department = _context.Departments.Find(votingPlace.DepartmentId);
      votingPlace.City = _context.Cities.Find(votingPlace.CityId);
      var votingPlaceView = new VotingPlaceViewModel
      {
        Id = votingPlace.VotingPlaceId,
        Code = votingPlace.Code,
        Name = votingPlace.Name,
        CountryId = votingPlace.Country.CountryId,
        CountryName = votingPlace.Country.Name,
        DepartmentId = votingPlace.Department.DepartmentId,
        DepartmentName = votingPlace.Department.Name,
        CityId = votingPlace.City.CityId,
        CityName = votingPlace.City.Name
      };

      return Ok(votingPlaceView);
    }

    [HttpPost]
    public IActionResult Create([FromBody] VotingPlace votingPlace)
    {
      if (votingPlace == null)
      {
        return BadRequest();
      }

      _context.VotingPlaces.Add(votingPlace);
      _context.SaveChanges();

      return CreatedAtRoute("GetVotingPlace", new { id = votingPlace.VotingPlaceId }, votingPlace);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] VotingPlace votingPlace)
    {
      if (votingPlace == null || votingPlace.VotingPlaceId != id)
      {
        return BadRequest();
      }

      var votingPlaceUpdate = _context.VotingPlaces.Find(id);
      if (votingPlaceUpdate == null)
      {
        return NotFound();
      }

      votingPlaceUpdate.Name = votingPlace.Name;
      votingPlaceUpdate.Code = votingPlace.Code;
      votingPlaceUpdate.CountryId = votingPlace.CountryId;
      votingPlaceUpdate.DepartmentId = votingPlace.DepartmentId;
      votingPlaceUpdate.CityId = votingPlace.CityId;

      _context.VotingPlaces.Update(votingPlaceUpdate);
      _context.SaveChanges();
      return CreatedAtRoute("GetVotingPlace", new { id = votingPlaceUpdate.VotingPlaceId }, votingPlaceUpdate);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      var city = _context.VotingPlaces.Find(id);
      if (city == null)
      {
        return NotFound();
      }

      _context.VotingPlaces.Remove(city);
      _context.SaveChanges();
      return NoContent();
    }
  }
}
