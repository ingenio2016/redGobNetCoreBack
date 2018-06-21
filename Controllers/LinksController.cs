using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    public Response GetAll()
    {
      var response = new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se encontró información", Data = { } };
      List<LinkViewModel> linkList = new List<LinkViewModel>();
      var links = _context.Links.ToList();
      if (links.Count > 0)
      {
        foreach (var link in links)
        {
          link.Country = _context.Countries.Find(link.CountryId);
          link.Department = _context.Departments.Find(link.DepartmentId);
          link.City = _context.Cities.Find(link.CityId);
          link.Commune = _context.Communes.Find(link.CommuneId);
          link.User = _context.DataUsers.Find(link.UserId);
          link.VotingPlace = _context.VotingPlaces.Find(link.VotingPlaceId);
          link.Genre = _context.Genres.Find(link.GenreId);
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
            GenreId = link.Genre.GenreId,
            GenreName = link.Genre.Name,
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

        response.Success = true;
        response.Result = HttpStatusCode.OK;
        response.Message = "La consulta se realizó exitosamente";
        response.Data = linkList;
      }
      return response;
    }

    [HttpGet("{id}", Name = "GetLink")]
    public Response GetById(int id)
    {
      var response = new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se encontró información", Data = { } };
      var link = _context.Links.Find(id);
      if (link == null)
      {
        return response;
      }
      link.Country = _context.Countries.Find(link.CountryId);
      link.Department = _context.Departments.Find(link.DepartmentId);
      link.City = _context.Cities.Find(link.CityId);
      link.Commune = _context.Communes.Find(link.CommuneId);
      link.User = _context.DataUsers.Find(link.UserId);
      link.VotingPlace = _context.VotingPlaces.Find(link.VotingPlaceId);
      link.Genre = _context.Genres.Find(link.GenreId);
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
        GenreId = link.Genre.GenreId,
        GenreName = link.Genre.Name,
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

      response.Success = true;
      response.Result = HttpStatusCode.OK;
      response.Message = "La consulta se realizó exitosamente";
      response.Data = linkView;

      return response;
    }

    [HttpPost]
    public async Task<Response> CreateAsync([FromBody] Link link)
    {
      if (link == null)
      {
        return new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se envió información", Data = { } };
      }
      using (var transaction = _context.Database.BeginTransaction())
      {
        var userIdentity = new AppUser { Email = link.Email, EmailConfirmed = true, FirstName = link.FirstName, LastName = link.LastName, UserName = link.Email };
        var userSystem = new User
        {
          FirstName = link.FirstName,
          LastName = link.LastName,
          Address = link.Address,
          CountryId = link.CountryId,
          DepartmentId = link.DepartmentId,
          CityId = link.CityId,
          GenreId = link.GenreId,
          Password = link.Email,
          Phone = link.CellPhone,
          Photo = "",
          UserName = link.Email,
          RoleUser = "Enlace"
        };
        _context.DataUsers.Add(userSystem);
        _context.Links.Add(link);
        try
        {
          var result = await _userManager.CreateAsync(userIdentity, link.Email);
          if (!result.Succeeded)
          {
            transaction.Rollback();
            return new Response { Success = false, Result = HttpStatusCode.InternalServerError, Message = "Ocurrió un error al crear el registro", Data = { } };
          }
          _context.SaveChanges();
          link.Country = _context.Countries.Find(link.CountryId);
          link.Department = _context.Departments.Find(link.DepartmentId);
          link.City = _context.Cities.Find(link.CityId);
          link.Commune = _context.Communes.Find(link.CommuneId);
          link.User = _context.DataUsers.Find(link.UserId);
          link.VotingPlace = _context.VotingPlaces.Find(link.VotingPlaceId);
          link.Genre = _context.Genres.Find(link.GenreId);
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
            GenreId = link.Genre.GenreId,
            GenreName = link.Genre.Name,
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
          transaction.Commit();
          return new Response { Success = true, Result = HttpStatusCode.OK, Message = "El registro se guardó exitosamente", Data = linkView };
        }
        catch (Exception ex)
        {
          transaction.Rollback();
          return new Response { Success = false, Result = HttpStatusCode.InternalServerError, Message = "Ocurrió un error al crear el registro", Data = { } };
        }
      }
    }

    [HttpPut("{id}")]
    public Response Update(int id, [FromBody] Link link)
    {
      if (link == null || link.LinkId != id)
      {
        return new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se envió información", Data = { } };
      }
      using (var transaction = _context.Database.BeginTransaction())
      {
        var linkUpdate = _context.Links.Find(id);
        if (linkUpdate == null)
        {
          return new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se encontró ningún registro", Data = { } };
        }
        linkUpdate.FirstName = link.FirstName;
        linkUpdate.LastName = link.LastName;
        linkUpdate.Document = link.Document;
        linkUpdate.Address = link.Address;
        linkUpdate.CountryId = link.CountryId;
        linkUpdate.DepartmentId = link.DepartmentId;
        linkUpdate.CityId = link.CityId;
        linkUpdate.GenreId = link.GenreId;
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

        var userSystem = _context.DataUsers.Where(du => du.UserName == linkUpdate.Email).FirstOrDefault();
        if (userSystem != null)
        {
          userSystem.FirstName = link.FirstName;
          userSystem.LastName = link.LastName;
          userSystem.Address = link.Address;
          userSystem.CountryId = link.CountryId;
          userSystem.DepartmentId = link.DepartmentId;
          userSystem.CityId = link.CityId;
          userSystem.GenreId = link.GenreId;
          userSystem.Phone = link.CellPhone;
          _context.DataUsers.Update(userSystem);
        }
        _context.Links.Update(linkUpdate);
        try
        {
          _context.SaveChanges();
          linkUpdate.Country = _context.Countries.Find(linkUpdate.CountryId);
          linkUpdate.Department = _context.Departments.Find(linkUpdate.DepartmentId);
          linkUpdate.City = _context.Cities.Find(linkUpdate.CityId);
          linkUpdate.Commune = _context.Communes.Find(linkUpdate.CommuneId);
          linkUpdate.User = _context.DataUsers.Find(linkUpdate.UserId);
          linkUpdate.VotingPlace = _context.VotingPlaces.Find(linkUpdate.VotingPlaceId);
          linkUpdate.Genre = _context.Genres.Find(linkUpdate.GenreId);
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
            GenreId = linkUpdate.Genre.GenreId,
            GenreName = linkUpdate.Genre.Name,
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
          transaction.Commit();
          return new Response { Success = true, Result = HttpStatusCode.OK, Message = "El registro se modificó exitosamente", Data = linkView };
        }
        catch (Exception)
        {
          transaction.Rollback();
          return new Response { Success = false, Result = HttpStatusCode.InternalServerError, Message = "Ocurrió un error al modificar el registro", Data = { } };
        }
      }
    }

    [HttpDelete("{id}")]
    public async Task<Response> DeleteAsync(int id)
    {
      using (var transaction = _context.Database.BeginTransaction())
      {
        var link = _context.Links.Find(id);
        if (link == null)
        {
          return new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se encontró ningún registro", Data = { } };
        }

        var userInfo = await _userManager.FindByEmailAsync(link.Email);
        _context.Links.Remove(link);
        try
        {
          var result = await _userManager.DeleteAsync(userInfo);
          if (!result.Succeeded)
          {
            transaction.Rollback();
            return new Response { Success = false, Result = HttpStatusCode.InternalServerError, Message = "Ocurrió un error al borrar el registro", Data = { } };
          }
          _context.SaveChanges();
          transaction.Commit();
          return new Response { Success = true, Result = HttpStatusCode.OK, Message = "El registro se borró exitosamente", Data = { } };
        }
        catch (Exception)
        {
          transaction.Rollback();
          return new Response { Success = false, Result = HttpStatusCode.InternalServerError, Message = "Ocurrió un error al borrar el registro", Data = { } };
        }
      }
    }
  }
}
