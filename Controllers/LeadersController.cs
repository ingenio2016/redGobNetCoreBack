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
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularASPNETCore2WebApiAuth.Controllers
{
  [Route("api/[controller]")]
  [EnableCors("CorsPolicy")]
  [Authorize]
  public class LeadersController : Controller
  {
    private readonly ApplicationDbContext _context;
    private readonly UserManager<AppUser> _userManager;
    private readonly IMapper _mapper;
    public LeadersController(ApplicationDbContext context)
    {
      _context = context;
    }

    [HttpGet]
    public List<LeaderViewModel> GetAll()
    {
      List<LeaderViewModel> leaderList = new List<LeaderViewModel>();
      var leaders = _context.Leaders.ToList();

      foreach (var leader in leaders)
      {
        var data = new LeaderViewModel
        {
          Id = leader.LeaderId,
          FirstName = leader.FirstName,
          LastName = leader.LastName,
          Document = leader.Document,
          Address = leader.Address,
          CountryId = leader.Country.CountryId,
          CountryName = leader.Country.Name,
          DepartmentId = leader.Department.DepartmentId,
          DepartmentName = leader.Department.Name,
          CityId = leader.City.CityId,
          CityName = leader.City.Name,
          CellPhone = leader.CellPhone,
          Association = leader.Association,
          CommuneId = leader.Commune.CommuneId,
          Commune = leader.Commune.Name,
          DateOfBirth = leader.DateOfBirth,
          Email = leader.Email,
          Latitude = leader.Latitude,
          Longitude = leader.Longitude,
          Ocupation = leader.Ocupation,
          UserId = leader.User.UserId,
          UserName = leader.User.FirstName + " " + leader.User.LastName,
          VotingPlaceId = leader.VotingPlace.VotingPlaceId,
          VotingPlace = leader.VotingPlace.Name,
          WorkPlace = leader.WorkPlace,
          Observation = leader.Observation
        };
        leaderList.Add(data);
      }

      return leaderList;
    }

    [HttpGet("{id}", Name = "GetLeader")]
    public IActionResult GetById(int id)
    {
      var leader = _context.Leaders.Find(id);
      if (leader == null)
      {
        return NotFound();
      }

      var leaderView = new LeaderViewModel
      {
        Id = leader.LeaderId,
        FirstName = leader.FirstName,
        LastName = leader.LastName,
        Document = leader.Document,
        Address = leader.Address,
        CountryId = leader.Country.CountryId,
        CountryName = leader.Country.Name,
        DepartmentId = leader.Department.DepartmentId,
        DepartmentName = leader.Department.Name,
        CityId = leader.City.CityId,
        CityName = leader.City.Name,
        CellPhone = leader.CellPhone,
        Association = leader.Association,
        CommuneId = leader.Commune.CommuneId,
        Commune = leader.Commune.Name,
        DateOfBirth = leader.DateOfBirth,
        Email = leader.Email,
        Latitude = leader.Latitude,
        Longitude = leader.Longitude,
        Ocupation = leader.Ocupation,
        UserId = leader.User.UserId,
        UserName = leader.User.FirstName + " " + leader.User.LastName,
        VotingPlaceId = leader.VotingPlace.VotingPlaceId,
        VotingPlace = leader.VotingPlace.Name,
        WorkPlace = leader.WorkPlace,
        Observation = leader.Observation
      };

      return Ok(leaderView);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] Leader leader)
    {
      if (leader == null)
      {
        return BadRequest();
      }

      //Create User
      var registrationModel = new UserViewModel
      {
        Address = leader.Address,
        CityId = leader.CityId,
        CountryId = leader.CountryId,
        DepartmentId = leader.DepartmentId,
        Email = leader.Email,
        EmailConfirmed = true,
        FirstName = leader.FirstName,
        LastName = leader.LastName,
        Password = leader.Email,
        Phone = leader.CellPhone.ToString(),
        PhoneNumber = leader.CellPhone.ToString(),
        UserEmail = leader.Email,
        UserName = leader.Email
      };

      var userIdentity = _mapper.Map<AppUser>(registrationModel);
      var result = await _userManager.CreateAsync(userIdentity, registrationModel.Password);
      if (!result.Succeeded) return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));
      var userRole = new UserInRole { UserId = Convert.ToInt32(userIdentity.Id), RoleName = "Lider" };
      _context.UserInRoles.Add(userRole);
      _context.Leaders.Add(leader);
      _context.SaveChanges();

      return CreatedAtRoute("GetLeader", new { id = leader.LeaderId }, leader);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Leader leader)
    {
      if (leader == null || leader.LeaderId != id)
      {
        return BadRequest();
      }

      var leaderUpdate = _context.Leaders.Find(id);
      if (leaderUpdate == null)
      {
        return NotFound();
      }

      leaderUpdate.FirstName = leader.FirstName;
      leaderUpdate.LastName = leader.LastName;
      leaderUpdate.Document = leader.Document;
      leaderUpdate.Address = leader.Address;
      leaderUpdate.CountryId = leader.CountryId;
      leaderUpdate.DepartmentId = leader.DepartmentId;
      leaderUpdate.CityId = leader.CityId;
      leaderUpdate.CellPhone = leader.CellPhone;
      leaderUpdate.Association = leader.Association;
      leaderUpdate.CommuneId = leader.CommuneId;
      leaderUpdate.DateOfBirth = leader.DateOfBirth;
      leaderUpdate.Latitude = leader.Latitude;
      leaderUpdate.Longitude = leader.Longitude;
      leaderUpdate.Ocupation = leader.Ocupation;
      leaderUpdate.UserId = leader.UserId;
      leaderUpdate.VotingPlaceId = leader.VotingPlaceId;
      leaderUpdate.WorkPlace = leader.WorkPlace;
      leaderUpdate.Observation = leader.Observation;

      _context.Leaders.Update(leaderUpdate);
      _context.SaveChanges();

      return CreatedAtRoute("GetLeader", new { id = leaderUpdate.LeaderId }, leaderUpdate);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
      var leader = _context.Leaders.Find(id);
      if (leader == null)
      {
        return NotFound();
      }

      var deleteModel = new UserViewModel
      {
        Address = leader.Address,
        CityId = leader.CityId,
        CountryId = leader.CountryId,
        DepartmentId = leader.DepartmentId,
        Email = leader.Email,
        EmailConfirmed = true,
        FirstName = leader.FirstName,
        LastName = leader.LastName,
        Password = leader.Email,
        Phone = leader.CellPhone.ToString(),
        PhoneNumber = leader.CellPhone.ToString(),
        UserEmail = leader.Email,
        UserName = leader.Email
      };

      var userIdentity = _mapper.Map<AppUser>(deleteModel);
      var result = await _userManager.DeleteAsync(userIdentity);
      if (!result.Succeeded) return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));

      _context.Leaders.Remove(leader);
      _context.SaveChanges();
      return NoContent();
    }
  }
}
