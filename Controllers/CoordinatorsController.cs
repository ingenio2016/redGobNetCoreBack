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
  public class CoordinatorsController : Controller
  {
    private readonly ApplicationDbContext _context;
    private readonly UserManager<AppUser> _userManager;
    private readonly IMapper _mapper;
    public CoordinatorsController(ApplicationDbContext context)
    {
      _context = context;
    }

    [HttpGet]
    public List<CoordinatorViewModel> GetAll()
    {
      List<CoordinatorViewModel> coordinatorList = new List<CoordinatorViewModel>();
      var coordinators = _context.Coordinators.ToList();

      foreach (var coordinator in coordinators)
      {
        var data = new CoordinatorViewModel
        {
          Id = coordinator.CoordinatorId,
          FirstName = coordinator.FirstName,
          LastName = coordinator.LastName,
          Document = coordinator.Document,
          Address = coordinator.Address,
          CountryId = coordinator.Country.CountryId,
          CountryName = coordinator.Country.Name,
          DepartmentId = coordinator.Department.DepartmentId,
          DepartmentName = coordinator.Department.Name,
          CityId = coordinator.City.CityId,
          CityName = coordinator.City.Name,
          CellPhone = coordinator.CellPhone,
          Association = coordinator.Association,
          CommuneId = coordinator.Commune.CommuneId,
          Commune = coordinator.Commune.Name,
          DateOfBirth = coordinator.DateOfBirth,
          Email = coordinator.Email,
          Latitude = coordinator.Latitude,
          Longitude = coordinator.Longitude,
          Ocupation = coordinator.Ocupation,
          UserId = coordinator.User.UserId,
          UserName = coordinator.User.FirstName + " " + coordinator.User.LastName,
          VotingPlaceId = coordinator.VotingPlace.VotingPlaceId,
          VotingPlace = coordinator.VotingPlace.Name,
          WorkPlace = coordinator.WorkPlace,
          Observation = coordinator.Observation
        };
        coordinatorList.Add(data);
      }

      return coordinatorList;
    }

    [HttpGet("{id}", Name = "GetCoordinator")]
    public IActionResult GetById(int id)
    {
      var coordinator = _context.Coordinators.Find(id);
      if (coordinator == null)
      {
        return NotFound();
      }

      var coordinatorView = new CoordinatorViewModel
      {
        Id = coordinator.CoordinatorId,
        FirstName = coordinator.FirstName,
        LastName = coordinator.LastName,
        Document = coordinator.Document,
        Address = coordinator.Address,
        CountryId = coordinator.Country.CountryId,
        CountryName = coordinator.Country.Name,
        DepartmentId = coordinator.Department.DepartmentId,
        DepartmentName = coordinator.Department.Name,
        CityId = coordinator.City.CityId,
        CityName = coordinator.City.Name,
        CellPhone = coordinator.CellPhone,
        Association = coordinator.Association,
        CommuneId = coordinator.Commune.CommuneId,
        Commune = coordinator.Commune.Name,
        DateOfBirth = coordinator.DateOfBirth,
        Email = coordinator.Email,
        Latitude = coordinator.Latitude,
        Longitude = coordinator.Longitude,
        Ocupation = coordinator.Ocupation,
        UserId = coordinator.User.UserId,
        UserName = coordinator.User.FirstName + " " + coordinator.User.LastName,
        VotingPlaceId = coordinator.VotingPlace.VotingPlaceId,
        VotingPlace = coordinator.VotingPlace.Name,
        WorkPlace = coordinator.WorkPlace,
        Observation = coordinator.Observation
      };

      return Ok(coordinatorView);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] Coordinator coordinator)
    {
      if (coordinator == null)
      {
        return BadRequest();
      }

      //Create User
      var registrationModel = new UserViewModel
      {
        Address = coordinator.Address,
        CityId = coordinator.CityId,
        CountryId = coordinator.CountryId,
        DepartmentId = coordinator.DepartmentId,
        Email = coordinator.Email,
        EmailConfirmed = true,
        FirstName = coordinator.FirstName,
        LastName = coordinator.LastName,
        Password = coordinator.Email,
        Phone = coordinator.CellPhone.ToString(),
        PhoneNumber = coordinator.CellPhone.ToString(),
        UserEmail = coordinator.Email,
        UserName = coordinator.Email
      };

      var userIdentity = _mapper.Map<AppUser>(registrationModel);
      var result = await _userManager.CreateAsync(userIdentity, registrationModel.Password);
      if (!result.Succeeded) return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));
      var userRole = new UserInRole { UserId = Convert.ToInt32(userIdentity.Id), RoleName = "Coordinador" };
      _context.UserInRoles.Add(userRole);
      _context.Coordinators.Add(coordinator);
      _context.SaveChanges();

      return CreatedAtRoute("GetCoordinator", new { id = coordinator.CoordinatorId }, coordinator);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Coordinator coordinator)
    {
      if (coordinator == null || coordinator.CoordinatorId != id)
      {
        return BadRequest();
      }

      var cordinatorUpdate = _context.Coordinators.Find(id);
      if (cordinatorUpdate == null)
      {
        return NotFound();
      }

      cordinatorUpdate.FirstName = coordinator.FirstName;
      cordinatorUpdate.LastName = coordinator.LastName;
      cordinatorUpdate.Document = coordinator.Document;
      cordinatorUpdate.Address = coordinator.Address;
      cordinatorUpdate.CountryId = coordinator.CountryId;
      cordinatorUpdate.DepartmentId = coordinator.DepartmentId;
      cordinatorUpdate.CityId = coordinator.CityId;
      cordinatorUpdate.CellPhone = coordinator.CellPhone;
      cordinatorUpdate.Association = coordinator.Association;
      cordinatorUpdate.CommuneId = coordinator.CommuneId;
      cordinatorUpdate.DateOfBirth = coordinator.DateOfBirth;
      cordinatorUpdate.Latitude = coordinator.Latitude;
      cordinatorUpdate.Longitude = coordinator.Longitude;
      cordinatorUpdate.Ocupation = coordinator.Ocupation;
      cordinatorUpdate.UserId = coordinator.UserId;
      cordinatorUpdate.VotingPlaceId = coordinator.VotingPlaceId;
      cordinatorUpdate.WorkPlace = coordinator.WorkPlace;
      cordinatorUpdate.Observation = coordinator.Observation;

      _context.Coordinators.Update(cordinatorUpdate);
      _context.SaveChanges();

      return CreatedAtRoute("GetCoordinator", new { id = cordinatorUpdate.CoordinatorId }, cordinatorUpdate);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
      var coordinator = _context.Coordinators.Find(id);
      if (coordinator == null)
      {
        return NotFound();
      }

      var deleteModel = new UserViewModel
      {
        Address = coordinator.Address,
        CityId = coordinator.CityId,
        CountryId = coordinator.CountryId,
        DepartmentId = coordinator.DepartmentId,
        Email = coordinator.Email,
        EmailConfirmed = true,
        FirstName = coordinator.FirstName,
        LastName = coordinator.LastName,
        Password = coordinator.Email,
        Phone = coordinator.CellPhone.ToString(),
        PhoneNumber = coordinator.CellPhone.ToString(),
        UserEmail = coordinator.Email,
        UserName = coordinator.Email
      };

      var userIdentity = _mapper.Map<AppUser>(deleteModel);
      var result = await _userManager.DeleteAsync(userIdentity);
      if (!result.Succeeded) return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));

      _context.Coordinators.Remove(coordinator);
      _context.SaveChanges();
      return NoContent();
    }
  }
}
