using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularASPNETCore2WebApiAuth.Data;
using AngularASPNETCore2WebApiAuth.Helpers;
using AngularASPNETCore2WebApiAuth.Models.Entities;
using AngularASPNETCore2WebApiAuth.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularASPNETCore2WebApiAuth.Controllers
{
  [Route("api/[controller]")]
  [Authorize]
  public class VotersController : Controller
  {
    private readonly ApplicationDbContext _context;
    private readonly UserManager<AppUser> _userManager;
    private readonly IMapper _mapper;
    public VotersController(ApplicationDbContext context)
    {
      _context = context;
    }

    [HttpGet]
    public List<VoterViewModel> GetAll()
    {
      List<VoterViewModel> voterList = new List<VoterViewModel>();
      var voters = _context.Voters.ToList();

      foreach (var voter in voters)
      {
        var data = new VoterViewModel
        {
          Id = voter.VoterId,
          FirstName = voter.FirstName,
          LastName = voter.LastName,
          Document = voter.Document,
          Address = voter.Address,
          CountryId = voter.Country.CountryId,
          CountryName = voter.Country.Name,
          DepartmentId = voter.Department.DepartmentId,
          DepartmentName = voter.Department.Name,
          CityId = voter.City.CityId,
          CityName = voter.City.Name,
          CellPhone = voter.CellPhone,
          Association = voter.Association,
          CommuneId = voter.Commune.CommuneId,
          Commune = voter.Commune.Name,
          DateOfBirth = voter.DateOfBirth,
          Email = voter.Email,
          Latitude = voter.Latitude,
          Longitude = voter.Longitude,
          Ocupation = voter.Ocupation,
          UserId = voter.User.UserId,
          UserName = voter.User.FirstName + " " + voter.User.LastName,
          VotingPlaceId = voter.VotingPlace.VotingPlaceId,
          VotingPlace = voter.VotingPlace.Name,
          WorkPlace = voter.WorkPlace,
          Observation = voter.Observation
        };
        voterList.Add(data);
      }

      return voterList;
    }

    [HttpGet("{id}", Name = "GetVoter")]
    public IActionResult GetById(int id)
    {
      var voter = _context.Voters.Find(id);
      if (voter == null)
      {
        return NotFound();
      }

      var voterView = new VoterViewModel
      {
        Id = voter.VoterId,
        FirstName = voter.FirstName,
        LastName = voter.LastName,
        Document = voter.Document,
        Address = voter.Address,
        CountryId = voter.Country.CountryId,
        CountryName = voter.Country.Name,
        DepartmentId = voter.Department.DepartmentId,
        DepartmentName = voter.Department.Name,
        CityId = voter.City.CityId,
        CityName = voter.City.Name,
        CellPhone = voter.CellPhone,
        Association = voter.Association,
        CommuneId = voter.Commune.CommuneId,
        Commune = voter.Commune.Name,
        DateOfBirth = voter.DateOfBirth,
        Email = voter.Email,
        Latitude = voter.Latitude,
        Longitude = voter.Longitude,
        Ocupation = voter.Ocupation,
        UserId = voter.User.UserId,
        UserName = voter.User.FirstName + " " + voter.User.LastName,
        VotingPlaceId = voter.VotingPlace.VotingPlaceId,
        VotingPlace = voter.VotingPlace.Name,
        WorkPlace = voter.WorkPlace,
        Observation = voter.Observation
      };

      return Ok(voterView);
    }

    [HttpPost]
    public IActionResult Create([FromBody] Voter voter)
    {
      if (voter == null)
      {
        return BadRequest();
      }

      //Create User
      var registrationModel = new UserViewModel
      {
        Address = voter.Address,
        CityId = voter.CityId,
        CountryId = voter.CountryId,
        DepartmentId = voter.DepartmentId,
        Email = voter.Email,
        EmailConfirmed = true,
        FirstName = voter.FirstName,
        LastName = voter.LastName,
        Password = voter.Email,
        Phone = voter.CellPhone.ToString(),
        PhoneNumber = voter.CellPhone.ToString(),
        UserEmail = voter.Email,
        UserName = voter.Email
      };

      _context.Voters.Add(voter);
      _context.SaveChanges();

      return CreatedAtRoute("GetVoter", new { id = voter.VoterId }, voter);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Voter voter)
    {
      if (voter == null || voter.VoterId != id)
      {
        return BadRequest();
      }

      var voterUpdate = _context.Voters.Find(id);
      if (voterUpdate == null)
      {
        return NotFound();
      }

      voterUpdate.FirstName = voter.FirstName;
      voterUpdate.LastName = voter.LastName;
      voterUpdate.Document = voter.Document;
      voterUpdate.Address = voter.Address;
      voterUpdate.CountryId = voter.CountryId;
      voterUpdate.DepartmentId = voter.DepartmentId;
      voterUpdate.CityId = voter.CityId;
      voterUpdate.CellPhone = voter.CellPhone;
      voterUpdate.Association = voter.Association;
      voterUpdate.CommuneId = voter.CommuneId;
      voterUpdate.DateOfBirth = voter.DateOfBirth;
      voterUpdate.Latitude = voter.Latitude;
      voterUpdate.Longitude = voter.Longitude;
      voterUpdate.Ocupation = voter.Ocupation;
      voterUpdate.UserId = voter.UserId;
      voterUpdate.VotingPlaceId = voter.VotingPlaceId;
      voterUpdate.WorkPlace = voter.WorkPlace;
      voterUpdate.Observation = voter.Observation;

      _context.Voters.Update(voterUpdate);
      _context.SaveChanges();

      return CreatedAtRoute("GetVoter", new { id = voterUpdate.VoterId }, voterUpdate);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      var voter = _context.Voters.Find(id);
      if (voter == null)
      {
        return NotFound();
      }

      _context.Voters.Remove(voter);
      _context.SaveChanges();
      return NoContent();
    }
  }
}
