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
  public class LinksController : Controller
  {
    private readonly ApplicationDbContext _context;
    private readonly UserManager<AppUser> _userManager;
    private readonly IMapper _mapper;
    public LinksController(UserManager<AppUser> userManager, IMapper mapper, ApplicationDbContext appDbContext)
    {
      _userManager = userManager;
      _mapper = mapper;
      _context = appDbContext;
    }

    [HttpGet]
    public List<LinkViewModel> GetAll()
    {
      List<LinkViewModel> linkList = new List<LinkViewModel>();
      var links = _context.Links.ToList();

      foreach (var link in links)
      {
        var data = new LinkViewModel
        {
          Id = link.LinkId,
          FirstName = link.FirstName,
          LastName = link.LastName,
          Document = link.Document,
          Address = link.Address,
          CountryId = link.Country.CountryId,
          CountryName = link.Country.Name,
          DepartmentId = link.Department.DepartmentId,
          DepartmentName = link.Department.Name,
          CityId = link.City.CityId,
          CityName = link.City.Name,
          CellPhone = link.CellPhone,
          Association = link.Association,
          CommuneId = link.Commune.CommuneId,
          Commune = link.Commune.Name,
          DateOfBirth = link.DateOfBirth,
          Email = link.Email,
          Latitude = link.Latitude,
          Longitude = link.Longitude,
          Ocupation = link.Ocupation,
          UserId = link.User.UserId,
          UserName = link.User.FirstName + " " + link.User.LastName,
          VotingPlaceId = link.VotingPlace.VotingPlaceId,
          VotingPlace = link.VotingPlace.Name,
          WorkPlace = link.WorkPlace,
          Observation = link.Observation
        };
        linkList.Add(data);
      }

      return linkList;
    }

    [HttpGet("{id}", Name = "GetLink")]
    public IActionResult GetById(int id)
    {
      var link = _context.Links.Find(id);
      if (link == null)
      {
        return NotFound();
      }

      var linkView = new LinkViewModel
      {
        Id = link.LinkId,
        FirstName = link.FirstName,
        LastName = link.LastName,
        Document = link.Document,
        Address = link.Address,
        CountryId = link.Country.CountryId,
        CountryName = link.Country.Name,
        DepartmentId = link.Department.DepartmentId,
        DepartmentName = link.Department.Name,
        CityId = link.City.CityId,
        CityName = link.City.Name,
        CellPhone = link.CellPhone,
        Association = link.Association,
        CommuneId = link.Commune.CommuneId,
        Commune = link.Commune.Name,
        DateOfBirth = link.DateOfBirth,
        Email = link.Email,
        Latitude = link.Latitude,
        Longitude = link.Longitude,
        Ocupation = link.Ocupation,
        UserId = link.User.UserId,
        UserName = link.User.FirstName + " " + link.User.LastName,
        VotingPlaceId = link.VotingPlace.VotingPlaceId,
        VotingPlace = link.VotingPlace.Name,
        WorkPlace = link.WorkPlace,
        Observation = link.Observation
      };

      return Ok(linkView);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] Link link)
    {
      if (link == null)
      {
        return BadRequest();
      }

      var userIdentity = new AppUser
      {
        Email = link.Email,
        EmailConfirmed = true,
        FirstName = link.FirstName,
        LastName = link.LastName,
        UserName = link.Email
      };

      var result = await _userManager.CreateAsync(userIdentity, link.Email);
      if (!result.Succeeded) return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));

      _context.Links.Add(link);
      _context.SaveChanges();

      link.Country = _context.Countries.Find(link.CountryId);
      link.Department = _context.Departments.Find(link.DepartmentId);
      link.City = _context.Cities.Find(link.CityId);
      link.Commune = _context.Communes.Find(link.CommuneId);
      link.User = _context.DataUsers.Find(link.UserId);
      link.VotingPlace = _context.VotingPlaces.Find(link.VotingPlaceId);
      var bossView = new LinkViewModel
      {
        Id = link.LinkId,
        FirstName = link.FirstName,
        LastName = link.LastName,
        Document = link.Document,
        Address = link.Address,
        CountryId = link.Country.CountryId,
        CountryName = link.Country.Name,
        DepartmentId = link.Department.DepartmentId,
        DepartmentName = link.Department.Name,
        CityId = link.City.CityId,
        CityName = link.City.Name,
        CellPhone = link.CellPhone,
        Association = link.Association,
        CommuneId = link.Commune.CommuneId,
        Commune = link.Commune.Name,
        DateOfBirth = link.DateOfBirth,
        Email = link.Email,
        Latitude = link.Latitude,
        Longitude = link.Longitude,
        Ocupation = link.Ocupation,
        UserId = link.User.UserId,
        UserName = link.User.FirstName + " " + link.User.LastName,
        VotingPlaceId = link.VotingPlace.VotingPlaceId,
        VotingPlace = link.VotingPlace.Name,
        WorkPlace = link.WorkPlace,
        Observation = link.Observation
      };

      return Ok(bossView);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Link link)
    {
      if (link == null || link.LinkId != id)
      {
        return BadRequest();
      }

      var linkUpdate = _context.Links.Find(id);
      if (linkUpdate == null)
      {
        return NotFound();
      }

      linkUpdate.FirstName = link.FirstName;
      linkUpdate.LastName = link.LastName;
      linkUpdate.Document = link.Document;
      linkUpdate.Address = link.Address;
      linkUpdate.CountryId = link.CountryId;
      linkUpdate.DepartmentId = link.DepartmentId;
      linkUpdate.CityId = link.CityId;
      linkUpdate.CellPhone = link.CellPhone;
      linkUpdate.Association = link.Association;
      linkUpdate.CommuneId = link.CommuneId;
      linkUpdate.DateOfBirth = link.DateOfBirth;
      linkUpdate.Latitude = link.Latitude;
      linkUpdate.Longitude = link.Longitude;
      linkUpdate.Ocupation = link.Ocupation;
      linkUpdate.UserId = link.UserId;
      linkUpdate.VotingPlaceId = link.VotingPlaceId;
      linkUpdate.WorkPlace = link.WorkPlace;
      linkUpdate.Observation = link.Observation;

      _context.Links.Update(linkUpdate);
      _context.SaveChanges();

      linkUpdate.Country = _context.Countries.Find(linkUpdate.CountryId);
      linkUpdate.Department = _context.Departments.Find(linkUpdate.DepartmentId);
      linkUpdate.City = _context.Cities.Find(linkUpdate.CityId);
      linkUpdate.Commune = _context.Communes.Find(linkUpdate.CommuneId);
      linkUpdate.User = _context.DataUsers.Find(linkUpdate.UserId);
      linkUpdate.VotingPlace = _context.VotingPlaces.Find(linkUpdate.VotingPlaceId);
      var linkView = new LinkViewModel
      {
        Id = linkUpdate.LinkId,
        FirstName = linkUpdate.FirstName,
        LastName = linkUpdate.LastName,
        Document = linkUpdate.Document,
        Address = linkUpdate.Address,
        CountryId = linkUpdate.Country.CountryId,
        CountryName = linkUpdate.Country.Name,
        DepartmentId = linkUpdate.Department.DepartmentId,
        DepartmentName = linkUpdate.Department.Name,
        CityId = linkUpdate.City.CityId,
        CityName = linkUpdate.City.Name,
        CellPhone = linkUpdate.CellPhone,
        Association = linkUpdate.Association,
        CommuneId = linkUpdate.Commune.CommuneId,
        Commune = linkUpdate.Commune.Name,
        DateOfBirth = linkUpdate.DateOfBirth,
        Email = linkUpdate.Email,
        Latitude = linkUpdate.Latitude,
        Longitude = linkUpdate.Longitude,
        Ocupation = linkUpdate.Ocupation,
        UserId = linkUpdate.User.UserId,
        UserName = linkUpdate.User.FirstName + " " + linkUpdate.User.LastName,
        VotingPlaceId = linkUpdate.VotingPlace.VotingPlaceId,
        VotingPlace = linkUpdate.VotingPlace.Name,
        WorkPlace = linkUpdate.WorkPlace,
        Observation = linkUpdate.Observation
      };

      return Ok(linkView);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
      var link = _context.Links.Find(id);
      if (link == null)
      {
        return NotFound();
      }

      var deleteModel = new UserViewModel
      {
        Address = link.Address,
        CityId = link.CityId,
        CountryId = link.CountryId,
        DepartmentId = link.DepartmentId,
        Email = link.Email,
        EmailConfirmed = true,
        FirstName = link.FirstName,
        LastName = link.LastName,
        Password = link.Email,
        Phone = link.CellPhone.ToString(),
        PhoneNumber = link.CellPhone.ToString(),
        UserEmail = link.Email,
        UserName = link.Email
      };

      var userInfo = await _userManager.FindByEmailAsync(link.Email);


      var result = await _userManager.DeleteAsync(userInfo);
      if (!result.Succeeded) return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));

      _context.Links.Remove(link);
      _context.SaveChanges();
      return NoContent();
    }
  }
}
