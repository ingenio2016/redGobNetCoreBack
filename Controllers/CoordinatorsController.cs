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
  public class CoordinatorsController : Controller
  {
    private readonly ApplicationDbContext _context;
    private readonly UserManager<AppUser> _userManager;
    private readonly IMapper _mapper;
    public CoordinatorsController(UserManager<AppUser> userManager, IMapper mapper, ApplicationDbContext appDbContext)
    {
      _userManager = userManager;
      _mapper = mapper;
      _context = appDbContext;
    }

    [HttpGet]
    public Response GetAll()
    {
      var response = new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se encontró información", Data = { } };
      List<CoordinatorViewModel> coordinatorsList = new List<CoordinatorViewModel>();
      var coordinators = _context.Coordinators.ToList();

      if (coordinators.Count > 0)
      {
        foreach (var coordinator in coordinators)
        {
          coordinator.Country = _context.Countries.Find(coordinator.CountryId);
          coordinator.Department = _context.Departments.Find(coordinator.DepartmentId);
          coordinator.City = _context.Cities.Find(coordinator.CityId);
          coordinator.Commune = _context.Communes.Find(coordinator.CommuneId);
          coordinator.User = _context.DataUsers.Find(coordinator.UserId);
          coordinator.VotingPlace = _context.VotingPlaces.Find(coordinator.VotingPlaceId);
          coordinator.Genre = _context.Genres.Find(coordinator.GenreId);
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
            GenreId = coordinator.Genre.GenreId,
            GenreName = coordinator.Genre.Name,
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
          coordinatorsList.Add(data);
        }

        response.Success = true;
        response.Result = HttpStatusCode.OK;
        response.Message = "La consulta se realizó exitosamente";
        response.Data = coordinatorsList;
      }
      return response;
    }

    [HttpGet("{id}", Name = "GetCoordinator")]
    public Response GetById(int id)
    {
      var response = new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se encontró información", Data = { } };
      var coordinator = _context.Coordinators.Find(id);
      if (coordinator == null)
      {
        return response;
      }
      coordinator.Country = _context.Countries.Find(coordinator.CountryId);
      coordinator.Department = _context.Departments.Find(coordinator.DepartmentId);
      coordinator.City = _context.Cities.Find(coordinator.CityId);
      coordinator.Commune = _context.Communes.Find(coordinator.CommuneId);
      coordinator.User = _context.DataUsers.Find(coordinator.UserId);
      coordinator.VotingPlace = _context.VotingPlaces.Find(coordinator.VotingPlaceId);
      coordinator.Genre = _context.Genres.Find(coordinator.GenreId);
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
        GenreId = coordinator.Genre.GenreId,
        GenreName = coordinator.Genre.Name,
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

      response.Success = true;
      response.Result = HttpStatusCode.OK;
      response.Message = "La consulta se realizó exitosamente";
      response.Data = coordinatorView;

      return response;
    }

    [HttpPost]
    public async Task<Response> CreateAsync([FromBody] Coordinator coordinator)
    {
      if (coordinator == null)
      {
        return new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se envió información", Data = { } };
      }
      using (var transaction = _context.Database.BeginTransaction())
      {
        var userIdentity = new AppUser { Email = coordinator.Email, EmailConfirmed = true, FirstName = coordinator.FirstName, LastName = coordinator.LastName, UserName = coordinator.Email };
        var userSystem = new User
        {
          FirstName = coordinator.FirstName,
          LastName = coordinator.LastName,
          Address = coordinator.Address,
          CountryId = coordinator.CountryId,
          DepartmentId = coordinator.DepartmentId,
          CityId = coordinator.CityId,
          GenreId = coordinator.GenreId,
          Password = coordinator.Email,
          Phone = coordinator.CellPhone,
          Photo = "",
          UserName = coordinator.Email,
          RoleUser = "Coordinador"
        };
        _context.DataUsers.Add(userSystem);
        _context.Coordinators.Add(coordinator);
        try
        {
          var result = await _userManager.CreateAsync(userIdentity, coordinator.Email);
          if (!result.Succeeded)
          {
            transaction.Rollback();
            return new Response { Success = false, Result = HttpStatusCode.InternalServerError, Message = "Ocurrió un error al crear el registro", Data = { } };
          }
          _context.SaveChanges();
          coordinator.Country = _context.Countries.Find(coordinator.CountryId);
          coordinator.Department = _context.Departments.Find(coordinator.DepartmentId);
          coordinator.City = _context.Cities.Find(coordinator.CityId);
          coordinator.Commune = _context.Communes.Find(coordinator.CommuneId);
          coordinator.User = _context.DataUsers.Find(coordinator.UserId);
          coordinator.VotingPlace = _context.VotingPlaces.Find(coordinator.VotingPlaceId);
          coordinator.Genre = _context.Genres.Find(coordinator.GenreId);
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
            GenreId = coordinator.Genre.GenreId,
            GenreName = coordinator.Genre.Name,
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
          transaction.Commit();
          return new Response { Success = true, Result = HttpStatusCode.OK, Message = "El registro se guardó exitosamente", Data = coordinatorView };
        }
        catch (Exception ex)
        {
          transaction.Rollback();
          return new Response { Success = false, Result = HttpStatusCode.InternalServerError, Message = "Ocurrió un error al crear el registro", Data = { } };
        }
      }
    }

    [HttpPut("{id}")]
    public Response Update(int id, [FromBody] Coordinator coordinator)
    {
      if (coordinator == null || coordinator.CoordinatorId != id)
      {
        return new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se envió información", Data = { } };
      }
      using (var transaction = _context.Database.BeginTransaction())
      {
        var coordinatorUpdate = _context.Coordinators.Find(id);
        if (coordinatorUpdate == null)
        {
          return new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se encontró ningún registro", Data = { } };
        }

        coordinatorUpdate.FirstName = coordinator.FirstName;
        coordinatorUpdate.LastName = coordinator.LastName;
        coordinatorUpdate.Document = coordinator.Document;
        coordinatorUpdate.Address = coordinator.Address;
        coordinatorUpdate.CountryId = coordinator.CountryId;
        coordinatorUpdate.DepartmentId = coordinator.DepartmentId;
        coordinatorUpdate.CityId = coordinator.CityId;
        coordinatorUpdate.GenreId = coordinator.GenreId;
        coordinatorUpdate.CellPhone = coordinator.CellPhone;
        coordinatorUpdate.Association = coordinator.Association;
        coordinatorUpdate.CommuneId = coordinator.CommuneId;
        coordinatorUpdate.DateOfBirth = coordinator.DateOfBirth;
        coordinatorUpdate.Latitude = coordinator.Latitude;
        coordinatorUpdate.Longitude = coordinator.Longitude;
        coordinatorUpdate.Ocupation = coordinator.Ocupation;
        coordinatorUpdate.UserId = coordinator.UserId;
        coordinatorUpdate.VotingPlaceId = coordinator.VotingPlaceId;
        coordinatorUpdate.WorkPlace = coordinator.WorkPlace;
        coordinatorUpdate.Observation = coordinator.Observation;

        var userSystem = _context.DataUsers.Where(du => du.UserName == coordinatorUpdate.Email).FirstOrDefault();
        if (userSystem != null)
        {
          userSystem.FirstName = coordinator.FirstName;
          userSystem.LastName = coordinator.LastName;
          userSystem.Address = coordinator.Address;
          userSystem.CountryId = coordinator.CountryId;
          userSystem.DepartmentId = coordinator.DepartmentId;
          userSystem.CityId = coordinator.CityId;
          userSystem.GenreId = coordinator.GenreId;
          userSystem.Phone = coordinator.CellPhone;
          _context.DataUsers.Update(userSystem);
        }
        _context.Coordinators.Update(coordinatorUpdate);
        try
        {
          _context.SaveChanges();
          coordinatorUpdate.Country = _context.Countries.Find(coordinatorUpdate.CountryId);
          coordinatorUpdate.Department = _context.Departments.Find(coordinatorUpdate.DepartmentId);
          coordinatorUpdate.City = _context.Cities.Find(coordinatorUpdate.CityId);
          coordinatorUpdate.Commune = _context.Communes.Find(coordinatorUpdate.CommuneId);
          coordinatorUpdate.User = _context.DataUsers.Find(coordinatorUpdate.UserId);
          coordinatorUpdate.VotingPlace = _context.VotingPlaces.Find(coordinatorUpdate.VotingPlaceId);
          coordinatorUpdate.Genre = _context.Genres.Find(coordinatorUpdate.GenreId);
          var coordinatorView = new CoordinatorViewModel
          {
            Id = coordinatorUpdate.CoordinatorId,
            FirstName = coordinatorUpdate.FirstName,
            LastName = coordinatorUpdate.LastName,
            Document = coordinatorUpdate.Document,
            Address = coordinatorUpdate.Address,
            CountryId = coordinatorUpdate.Country.CountryId,
            CountryName = coordinatorUpdate.Country.Name,
            DepartmentId = coordinatorUpdate.Department.DepartmentId,
            DepartmentName = coordinatorUpdate.Department.Name,
            CityId = coordinatorUpdate.City.CityId,
            CityName = coordinatorUpdate.City.Name,
            GenreId = coordinatorUpdate.Genre.GenreId,
            GenreName = coordinatorUpdate.Genre.Name,
            CellPhone = coordinatorUpdate.CellPhone,
            Association = coordinatorUpdate.Association,
            CommuneId = coordinatorUpdate.Commune.CommuneId,
            Commune = coordinatorUpdate.Commune.Name,
            DateOfBirth = coordinatorUpdate.DateOfBirth,
            Email = coordinatorUpdate.Email,
            Latitude = coordinatorUpdate.Latitude,
            Longitude = coordinatorUpdate.Longitude,
            Ocupation = coordinatorUpdate.Ocupation,
            UserId = coordinatorUpdate.User.UserId,
            UserName = coordinatorUpdate.User.FirstName + " " + coordinatorUpdate.User.LastName,
            VotingPlaceId = coordinatorUpdate.VotingPlace.VotingPlaceId,
            VotingPlace = coordinatorUpdate.VotingPlace.Name,
            WorkPlace = coordinatorUpdate.WorkPlace,
            Observation = coordinatorUpdate.Observation
          };
          transaction.Commit();
          return new Response { Success = true, Result = HttpStatusCode.OK, Message = "El registro se modificó exitosamente", Data = coordinatorView };
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
        var coordinator = _context.Coordinators.Find(id);
        if (coordinator == null)
        {
          return new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se encontró ningún registro", Data = { } };
        }

        var userInfo = await _userManager.FindByEmailAsync(coordinator.Email);
        _context.Coordinators.Remove(coordinator);
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
