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
  public class LeadersController : Controller
  {
    private readonly ApplicationDbContext _context;
    private readonly UserManager<AppUser> _userManager;
    private readonly IMapper _mapper;
    public LeadersController(UserManager<AppUser> userManager, IMapper mapper, ApplicationDbContext appDbContext)
    {
      _userManager = userManager;
      _mapper = mapper;
      _context = appDbContext;
    }

    [HttpGet]
    public Response GetAll()
    {
      var response = new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se encontró información", Data = { } };
      List<LeaderViewModel> leaderList = new List<LeaderViewModel>();
      var leaders = _context.Leaders.ToList();

      if (leaders.Count > 0)
      {
        foreach (var leader in leaders)
        {
          leader.Country = _context.Countries.Find(leader.CountryId);
          leader.Department = _context.Departments.Find(leader.DepartmentId);
          leader.City = _context.Cities.Find(leader.CityId);
          leader.Commune = _context.Communes.Find(leader.CommuneId);
          leader.User = _context.DataUsers.Find(leader.UserId);
          leader.VotingPlace = _context.VotingPlaces.Find(leader.VotingPlaceId);
          leader.Genre = _context.Genres.Find(leader.GenreId);
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
            GenreId = leader.Genre.GenreId,
            GenreName = leader.Genre.Name,
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

        response.Success = true;
        response.Result = HttpStatusCode.OK;
        response.Message = "La consulta se realizó exitosamente";
        response.Data = leaderList;
      }
      return response;
    }

    [HttpGet("{id}", Name = "GetLeader")]
    public Response GetById(int id)
    {
      var response = new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se encontró información", Data = { } };
      var leader = _context.Leaders.Find(id);
      if (leader == null)
      {
        return response;
      }
      leader.Country = _context.Countries.Find(leader.CountryId);
      leader.Department = _context.Departments.Find(leader.DepartmentId);
      leader.City = _context.Cities.Find(leader.CityId);
      leader.Commune = _context.Communes.Find(leader.CommuneId);
      leader.User = _context.DataUsers.Find(leader.UserId);
      leader.VotingPlace = _context.VotingPlaces.Find(leader.VotingPlaceId);
      leader.Genre = _context.Genres.Find(leader.GenreId);
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
        GenreId = leader.Genre.GenreId,
        GenreName = leader.Genre.Name,
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

      response.Success = true;
      response.Result = HttpStatusCode.OK;
      response.Message = "La consulta se realizó exitosamente";
      response.Data = leaderView;

      return response;
    }

    [HttpPost]
    public async Task<Response> CreateAsync([FromBody] Leader leader)
    {
      if (leader == null)
      {
        return new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se envió información", Data = { } };
      }
      using (var transaction = _context.Database.BeginTransaction())
      {
        var userIdentity = new AppUser { Email = leader.Email, EmailConfirmed = true, FirstName = leader.FirstName, LastName = leader.LastName, UserName = leader.Email };
        var userSystem = new User
        {
          FirstName = leader.FirstName,
          LastName = leader.LastName,
          Address = leader.Address,
          CountryId = leader.CountryId,
          DepartmentId = leader.DepartmentId,
          CityId = leader.CityId,
          GenreId = leader.GenreId,
          Password = leader.Email,
          Phone = leader.CellPhone,
          Photo = "",
          UserName = leader.Email,
          RoleUser = "Lider"
        };
        _context.DataUsers.Add(userSystem);
        _context.Leaders.Add(leader);
        try
        {
          var result = await _userManager.CreateAsync(userIdentity, leader.Email);
          if (!result.Succeeded)
          {
            transaction.Rollback();
            return new Response { Success = false, Result = HttpStatusCode.InternalServerError, Message = "Ocurrió un error al crear el registro", Data = { } };
          }
          _context.SaveChanges();
          leader.Country = _context.Countries.Find(leader.CountryId);
          leader.Department = _context.Departments.Find(leader.DepartmentId);
          leader.City = _context.Cities.Find(leader.CityId);
          leader.Commune = _context.Communes.Find(leader.CommuneId);
          leader.User = _context.DataUsers.Find(leader.UserId);
          leader.VotingPlace = _context.VotingPlaces.Find(leader.VotingPlaceId);
          leader.Genre = _context.Genres.Find(leader.GenreId);
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
            GenreId = leader.Genre.GenreId,
            GenreName = leader.Genre.Name,
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
          transaction.Commit();
          return new Response { Success = true, Result = HttpStatusCode.OK, Message = "El registro se guardó exitosamente", Data = leaderView };
        }
        catch (Exception ex)
        {
          transaction.Rollback();
          return new Response { Success = false, Result = HttpStatusCode.InternalServerError, Message = "Ocurrió un error al crear el registro", Data = { } };
        }
      }
    }

    [HttpPut("{id}")]
    public Response Update(int id, [FromBody] Leader leader)
    {
      if (leader == null || leader.LeaderId != id)
      {
        return new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se envió información", Data = { } };
      }
      using (var transaction = _context.Database.BeginTransaction())
      {
        var leaderUpdate = _context.Leaders.Find(id);
        if (leaderUpdate == null)
        {
          return new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se encontró ningún registro", Data = { } };
        }

        leaderUpdate.FirstName = leader.FirstName;
        leaderUpdate.LastName = leader.LastName;
        leaderUpdate.Document = leader.Document;
        leaderUpdate.Address = leader.Address;
        leaderUpdate.CountryId = leader.CountryId;
        leaderUpdate.DepartmentId = leader.DepartmentId;
        leaderUpdate.CityId = leader.CityId;
        leaderUpdate.GenreId = leader.GenreId;
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

        var userSystem = _context.DataUsers.Where(du => du.UserName == leaderUpdate.Email).FirstOrDefault();
        if (userSystem != null)
        {
          userSystem.FirstName = leader.FirstName;
          userSystem.LastName = leader.LastName;
          userSystem.Address = leader.Address;
          userSystem.CountryId = leader.CountryId;
          userSystem.DepartmentId = leader.DepartmentId;
          userSystem.CityId = leader.CityId;
          userSystem.GenreId = leader.GenreId;
          userSystem.Phone = leader.CellPhone;
          _context.DataUsers.Update(userSystem);
        }
        _context.Leaders.Update(leaderUpdate);
        try
        {
          _context.SaveChanges();

          leaderUpdate.Country = _context.Countries.Find(leaderUpdate.CountryId);
          leaderUpdate.Department = _context.Departments.Find(leaderUpdate.DepartmentId);
          leaderUpdate.City = _context.Cities.Find(leaderUpdate.CityId);
          leaderUpdate.Commune = _context.Communes.Find(leaderUpdate.CommuneId);
          leaderUpdate.User = _context.DataUsers.Find(leaderUpdate.UserId);
          leaderUpdate.VotingPlace = _context.VotingPlaces.Find(leaderUpdate.VotingPlaceId);
          leaderUpdate.Genre = _context.Genres.Find(leaderUpdate.GenreId);
          var leaderView = new LeaderViewModel
          {
            Id = leaderUpdate.LeaderId,
            FirstName = leaderUpdate.FirstName,
            LastName = leaderUpdate.LastName,
            Document = leaderUpdate.Document,
            Address = leaderUpdate.Address,
            CountryId = leaderUpdate.Country.CountryId,
            CountryName = leaderUpdate.Country.Name,
            DepartmentId = leaderUpdate.Department.DepartmentId,
            DepartmentName = leaderUpdate.Department.Name,
            CityId = leaderUpdate.City.CityId,
            CityName = leaderUpdate.City.Name,
            GenreId = leaderUpdate.Genre.GenreId,
            GenreName = leaderUpdate.Genre.Name,
            CellPhone = leaderUpdate.CellPhone,
            Association = leaderUpdate.Association,
            CommuneId = leaderUpdate.Commune.CommuneId,
            Commune = leaderUpdate.Commune.Name,
            DateOfBirth = leaderUpdate.DateOfBirth,
            Email = leaderUpdate.Email,
            Latitude = leaderUpdate.Latitude,
            Longitude = leaderUpdate.Longitude,
            Ocupation = leaderUpdate.Ocupation,
            UserId = leaderUpdate.User.UserId,
            UserName = leaderUpdate.User.FirstName + " " + leaderUpdate.User.LastName,
            VotingPlaceId = leaderUpdate.VotingPlace.VotingPlaceId,
            VotingPlace = leaderUpdate.VotingPlace.Name,
            WorkPlace = leaderUpdate.WorkPlace,
            Observation = leaderUpdate.Observation
          };
          transaction.Commit();
          return new Response { Success = true, Result = HttpStatusCode.OK, Message = "El registro se modificó exitosamente", Data = leaderView };
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
        var leader = _context.Leaders.Find(id);
        if (leader == null)
        {
          return new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se encontró ningún registro", Data = { } };
        }

        var userInfo = await _userManager.FindByEmailAsync(leader.Email);
       _context.Leaders.Remove(leader);
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
