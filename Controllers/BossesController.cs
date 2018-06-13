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
  public class BossesController : Controller
  {
    private readonly ApplicationDbContext _context;
    private readonly UserManager<AppUser> _userManager;
    private readonly IMapper _mapper;
    public BossesController(ApplicationDbContext context)
    {
      _context = context;
    }

    [HttpGet]
    public List<BossViewModel> GetAll()
    {
      List<BossViewModel> bossList = new List<BossViewModel>();
      var bosses = _context.Bosses.ToList();

      foreach (var boss in bosses)
      {
        boss.Country = _context.Countries.Find(boss.CountryId);
        boss.Department = _context.Departments.Find(boss.DepartmentId);
        boss.City = _context.Cities.Find(boss.CityId);
        boss.Commune = _context.Communes.Find(boss.CommuneId);
        boss.User = _context.DataUsers.Find(boss.UserId);
        boss.VotingPlace = _context.VotingPlaces.Find(boss.VotingPlaceId);
        var data = new BossViewModel
        {
          Id = boss.BossId,
          FirstName = boss.FirstName,
          LastName = boss.LastName,
          Document = boss.Document,
          Address = boss.Address,
          CountryId = boss.Country.CountryId,
          CountryName = boss.Country.Name,
          DepartmentId = boss.Department.DepartmentId,
          DepartmentName = boss.Department.Name,
          CityId = boss.City.CityId,
          CityName = boss.City.Name,
          CellPhone = boss.CellPhone,
          Association = boss.Association,
          CommuneId = boss.Commune.CommuneId,
          Commune = boss.Commune.Name,
          DateOfBirth = boss.DateOfBirth,
          Email = boss.Email,
          Latitude = boss.Latitude,
          Longitude = boss.Longitude,
          Ocupation = boss.Ocupation,
          UserId = boss.User.UserId,
          UserName = boss.User.FirstName + " " + boss.User.LastName,
          VotingPlaceId = boss.VotingPlace.VotingPlaceId,
          VotingPlace = boss.VotingPlace.Name,
          WorkPlace = boss.WorkPlace,
          Observation = boss.Observation
        };
        bossList.Add(data);
      }

      return bossList;
    }

    [HttpGet("{id}", Name = "GetBoss")]
    public IActionResult GetById(int id)
    {
      var boss = _context.Bosses.Find(id);
      if (boss == null)
      {
        return NotFound();
      }
      boss.Country = _context.Countries.Find(boss.CountryId);
      boss.Department = _context.Departments.Find(boss.DepartmentId);
      boss.City = _context.Cities.Find(boss.CityId);
      boss.Commune = _context.Communes.Find(boss.CommuneId);
      boss.User = _context.DataUsers.Find(boss.UserId);
      boss.VotingPlace = _context.VotingPlaces.Find(boss.VotingPlaceId);
      var bossView = new BossViewModel
      {
        Id = boss.BossId,
        FirstName = boss.FirstName,
        LastName = boss.LastName,
        Document = boss.Document,
        Address = boss.Address,
        CountryId = boss.Country.CountryId,
        CountryName = boss.Country.Name,
        DepartmentId = boss.Department.DepartmentId,
        DepartmentName = boss.Department.Name,
        CityId = boss.City.CityId,
        CityName = boss.City.Name,
        CellPhone = boss.CellPhone,
        Association = boss.Association,
        CommuneId = boss.Commune.CommuneId,
        Commune = boss.Commune.Name,
        DateOfBirth = boss.DateOfBirth,
        Email = boss.Email,
        Latitude = boss.Latitude,
        Longitude = boss.Longitude,
        Ocupation = boss.Ocupation,
        UserId = boss.User.UserId,
        UserName = boss.User.FirstName + " " + boss.User.LastName,
        VotingPlaceId = boss.VotingPlace.VotingPlaceId,
        VotingPlace = boss.VotingPlace.Name,
        WorkPlace = boss.WorkPlace,
        Observation = boss.Observation
      };

      return Ok(bossView);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] Boss boss)
    {
      if (boss == null)
      {
        return BadRequest();
      }

      //Create User
      var registrationModel = new UserViewModel
      {
        Address = boss.Address,
        CityId = boss.CityId,
        CountryId = boss.CountryId,
        DepartmentId = boss.DepartmentId,
        Email = boss.Email,
        EmailConfirmed = true,
        FirstName = boss.FirstName,
        LastName = boss.LastName,
        Password = boss.Email,
        Phone = boss.CellPhone.ToString(),
        PhoneNumber = boss.CellPhone.ToString(),
        UserEmail = boss.Email,
        UserName = boss.Email
      };

      var userIdentity = _mapper.Map<AppUser>(registrationModel);
      var result = await _userManager.CreateAsync(userIdentity, registrationModel.Password);
      if (!result.Succeeded) return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));
      var userRole = new UserInRole { UserId = Convert.ToInt32(userIdentity.Id), RoleName = "Jefe" };
      _context.UserInRoles.Add(userRole);
      _context.Bosses.Add(boss);
      _context.SaveChanges();

      return CreatedAtRoute("GetBoss", new { id = boss.BossId }, boss);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Boss boss)
    {
      if (boss == null || boss.BossId != id)
      {
        return BadRequest();
      }

      var bossUpdate = _context.Bosses.Find(id);
      if (bossUpdate == null)
      {
        return NotFound();
      }

      bossUpdate.FirstName = boss.FirstName;
      bossUpdate.LastName = boss.LastName;
      bossUpdate.Document = boss.Document;
      bossUpdate.Address = boss.Address;
      bossUpdate.CountryId = boss.CountryId;
      bossUpdate.DepartmentId = boss.DepartmentId;
      bossUpdate.CityId = boss.CityId;
      bossUpdate.CellPhone = boss.CellPhone;
      bossUpdate.Association = boss.Association;
      bossUpdate.CommuneId = boss.CommuneId;
      bossUpdate.DateOfBirth = boss.DateOfBirth;
      bossUpdate.Latitude = boss.Latitude;
      bossUpdate.Longitude = boss.Longitude;
      bossUpdate.Ocupation = boss.Ocupation;
      bossUpdate.UserId = boss.UserId;
      bossUpdate.VotingPlaceId = boss.VotingPlaceId;
      bossUpdate.WorkPlace = boss.WorkPlace;
      bossUpdate.Observation = boss.Observation;

      _context.Bosses.Update(bossUpdate);
      _context.SaveChanges();

      return CreatedAtRoute("GetBoss", new { id = bossUpdate.BossId }, bossUpdate);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
      var boss = _context.Bosses.Find(id);
      if (boss == null)
      {
        return NotFound();
      }

      var deleteModel = new UserViewModel
      {
        Address = boss.Address,
        CityId = boss.CityId,
        CountryId = boss.CountryId,
        DepartmentId = boss.DepartmentId,
        Email = boss.Email,
        EmailConfirmed = true,
        FirstName = boss.FirstName,
        LastName = boss.LastName,
        Password = boss.Email,
        Phone = boss.CellPhone.ToString(),
        PhoneNumber = boss.CellPhone.ToString(),
        UserEmail = boss.Email,
        UserName = boss.Email
      };

      var userIdentity = _mapper.Map<AppUser>(deleteModel);
      var result = await _userManager.DeleteAsync(userIdentity);
      if (!result.Succeeded) return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));

      _context.Bosses.Remove(boss);
      _context.SaveChanges();
      return NoContent();
    }
  }
}