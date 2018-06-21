using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Transactions;
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
  public class BossesController : Controller
  {
    private readonly ApplicationDbContext _context;
    private readonly UserManager<AppUser> _userManager;
    private readonly IMapper _mapper;
    public BossesController(UserManager<AppUser> userManager, IMapper mapper, ApplicationDbContext appDbContext)
    {
      _userManager = userManager;
      _mapper = mapper;
      _context = appDbContext;
    }

    [HttpGet]
    public Response GetAll()
    {
      var response = new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se encontró información", Data = { }};
      List<BossViewModel> bossList = new List<BossViewModel>();
      var bosses = _context.Bosses.ToList();
      if(bosses.Count > 0)
      {
        foreach (var boss in bosses)
        {
          boss.Country = _context.Countries.Find(boss.CountryId);
          boss.Department = _context.Departments.Find(boss.DepartmentId);
          boss.City = _context.Cities.Find(boss.CityId);
          boss.Commune = _context.Communes.Find(boss.CommuneId);
          boss.User = _context.DataUsers.Find(boss.UserId);
          boss.VotingPlace = _context.VotingPlaces.Find(boss.VotingPlaceId);
          boss.Genre = _context.Genres.Find(boss.GenreId);
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
            GenreId = boss.Genre.GenreId,
            GenreName = boss.Genre.Name,
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
        response.Success = true;
        response.Result = HttpStatusCode.OK;
        response.Message = "La consulta se realizó exitosamente";
        response.Data = bossList;
      }      
      return response;
    }

    [HttpGet("{id}", Name = "GetBoss")]
    public Response GetById(int id)
    {
      var response = new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se encontró información", Data = { }};
      var boss = _context.Bosses.Find(id);
      if (boss == null)
      {
        return response;
      }
      boss.Country = _context.Countries.Find(boss.CountryId);
      boss.Department = _context.Departments.Find(boss.DepartmentId);
      boss.City = _context.Cities.Find(boss.CityId);
      boss.Commune = _context.Communes.Find(boss.CommuneId);
      boss.User = _context.DataUsers.Find(boss.UserId);
      boss.VotingPlace = _context.VotingPlaces.Find(boss.VotingPlaceId);
      boss.Genre = _context.Genres.Find(boss.GenreId);
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
        GenreId = boss.Genre.GenreId,
        GenreName = boss.Genre.Name,
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
      response.Success = true;
      response.Result = HttpStatusCode.OK;
      response.Message = "La consulta se realizó exitosamente";
      response.Data = bossView;
      return response;
    }

    [HttpPost]
    public async Task<Response> CreateAsync([FromBody] Boss boss)
    {      
      if (boss == null)
      {
        return new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se envió información", Data = { } };
      }
      using (var transaction = _context.Database.BeginTransaction())
      {

        var userIdentity = new AppUser { Email = boss.Email, EmailConfirmed = true, FirstName = boss.FirstName, LastName = boss.LastName, UserName = boss.Email };
        var userSystem = new User
        {
          FirstName = boss.FirstName,
          LastName = boss.LastName,
          Address = boss.Address,
          CountryId = boss.CountryId,
          DepartmentId = boss.DepartmentId,
          CityId = boss.CityId,
          GenreId = boss.GenreId,
          Password = boss.Email,
          Phone = boss.CellPhone,
          Photo = "",
          UserName = boss.Email,
          RoleUser = "Jefe"
        };
        _context.DataUsers.Add(userSystem);
        _context.Bosses.Add(boss);
        try
        {
          var result = await _userManager.CreateAsync(userIdentity, boss.Email);
          if (!result.Succeeded)
          {
            transaction.Rollback();
            return new Response { Success = false, Result = HttpStatusCode.InternalServerError, Message = "Ocurrió un error al crear el registro", Data = { } };
          }
          _context.SaveChanges();
          boss.Country = _context.Countries.Find(boss.CountryId);
          boss.Department = _context.Departments.Find(boss.DepartmentId);
          boss.City = _context.Cities.Find(boss.CityId);
          boss.Commune = _context.Communes.Find(boss.CommuneId);
          boss.User = _context.DataUsers.Find(boss.UserId);
          boss.VotingPlace = _context.VotingPlaces.Find(boss.VotingPlaceId);
          boss.Genre = _context.Genres.Find(boss.GenreId);
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
            GenreId = boss.Genre.GenreId,
            GenreName = boss.Genre.Name,
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
          transaction.Commit();
          return new Response { Success = true, Result = HttpStatusCode.OK, Message = "El registro se guardó exitosamente", Data = bossView };
        }
        catch (Exception ex)
        {
          transaction.Rollback();
          return new Response { Success = false, Result = HttpStatusCode.InternalServerError, Message = "Ocurrió un error al crear el registro", Data = { } };
        }
      }
    }

    [HttpPut("{id}")]
    public Response Update(int id, [FromBody] Boss boss)
    {
      if (boss == null || boss.BossId != id)
      {
        return new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se envió información", Data = { } };
      }
      using (var transaction = _context.Database.BeginTransaction())
      {
        var bossUpdate = _context.Bosses.Find(id);
        if (bossUpdate == null)
        {
          return new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se encontró ningún registro", Data = { } };
        }

        bossUpdate.FirstName = boss.FirstName;
        bossUpdate.LastName = boss.LastName;
        bossUpdate.Document = boss.Document;
        bossUpdate.Address = boss.Address;
        bossUpdate.CountryId = boss.CountryId;
        bossUpdate.DepartmentId = boss.DepartmentId;
        bossUpdate.CityId = boss.CityId;
        bossUpdate.GenreId = boss.GenreId;
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

        var userSystem = _context.DataUsers.Where(du => du.UserName == bossUpdate.Email).FirstOrDefault();
        if (userSystem != null)
        {
          userSystem.FirstName = boss.FirstName;
          userSystem.LastName = boss.LastName;
          userSystem.Address = boss.Address;
          userSystem.CountryId = boss.CountryId;
          userSystem.DepartmentId = boss.DepartmentId;
          userSystem.CityId = boss.CityId;
          userSystem.GenreId = boss.GenreId;
          userSystem.Phone = boss.CellPhone;
          _context.DataUsers.Update(userSystem);
        }
        _context.Bosses.Update(bossUpdate);
        try
        {
          _context.SaveChanges();
          bossUpdate.Country = _context.Countries.Find(bossUpdate.CountryId);
          bossUpdate.Department = _context.Departments.Find(bossUpdate.DepartmentId);
          bossUpdate.City = _context.Cities.Find(bossUpdate.CityId);
          bossUpdate.Commune = _context.Communes.Find(bossUpdate.CommuneId);
          bossUpdate.User = _context.DataUsers.Find(bossUpdate.UserId);
          bossUpdate.VotingPlace = _context.VotingPlaces.Find(bossUpdate.VotingPlaceId);
          bossUpdate.Genre = _context.Genres.Find(bossUpdate.GenreId);
          var bossView = new BossViewModel
          {
            Id = bossUpdate.BossId,
            FirstName = bossUpdate.FirstName,
            LastName = bossUpdate.LastName,
            Document = bossUpdate.Document,
            Address = bossUpdate.Address,
            CountryId = bossUpdate.Country.CountryId,
            CountryName = bossUpdate.Country.Name,
            DepartmentId = bossUpdate.Department.DepartmentId,
            DepartmentName = bossUpdate.Department.Name,
            CityId = bossUpdate.City.CityId,
            CityName = bossUpdate.City.Name,
            GenreId = bossUpdate.Genre.GenreId,
            GenreName = bossUpdate.Genre.Name,
            CellPhone = bossUpdate.CellPhone,
            Association = bossUpdate.Association,
            CommuneId = bossUpdate.Commune.CommuneId,
            Commune = bossUpdate.Commune.Name,
            DateOfBirth = bossUpdate.DateOfBirth,
            Email = bossUpdate.Email,
            Latitude = bossUpdate.Latitude,
            Longitude = bossUpdate.Longitude,
            Ocupation = bossUpdate.Ocupation,
            UserId = bossUpdate.User.UserId,
            UserName = bossUpdate.User.FirstName + " " + bossUpdate.User.LastName,
            VotingPlaceId = bossUpdate.VotingPlace.VotingPlaceId,
            VotingPlace = bossUpdate.VotingPlace.Name,
            WorkPlace = bossUpdate.WorkPlace,
            Observation = bossUpdate.Observation
          };
          transaction.Commit();
          return new Response { Success = true, Result = HttpStatusCode.OK, Message = "El registro se modificó exitosamente", Data = bossView };
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
        var boss = _context.Bosses.Find(id);
        if (boss == null)
        {
          return new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se encontró ningún registro", Data = { } };
        }

        var userInfo = await _userManager.FindByEmailAsync(boss.Email);
        _context.Bosses.Remove(boss);
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
