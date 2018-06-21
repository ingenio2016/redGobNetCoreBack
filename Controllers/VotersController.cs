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
  public class VotersController : Controller
  {
    private readonly ApplicationDbContext _context;
    private readonly UserManager<AppUser> _userManager;
    private readonly IMapper _mapper;
    public VotersController(UserManager<AppUser> userManager, IMapper mapper, ApplicationDbContext appDbContext)
    {
      _userManager = userManager;
      _mapper = mapper;
      _context = appDbContext;
    }

    [HttpGet]
    public Response GetAll()
    {
      var response = new Response
      {
        Success = false,
        Result = HttpStatusCode.NotFound,
        Message = "No se encontró información",
        Data = { }

      };
      List<VoterViewModel> voterList = new List<VoterViewModel>();
      var voters = _context.Voters.ToList();

      if (voters.Count > 0)
      {
        foreach (var voter in voters)
        {
          voter.Country = _context.Countries.Find(voter.CountryId);
          voter.Department = _context.Departments.Find(voter.DepartmentId);
          voter.City = _context.Cities.Find(voter.CityId);
          voter.Commune = _context.Communes.Find(voter.CommuneId);
          voter.User = _context.DataUsers.Find(voter.UserId);
          voter.VotingPlace = _context.VotingPlaces.Find(voter.VotingPlaceId);
          voter.Genre = _context.Genres.Find(voter.GenreId);
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
            GenreId = voter.Genre.GenreId,
            GenreName = voter.Genre.Name,
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

        response.Success = true;
        response.Result = HttpStatusCode.OK;
        response.Message = "La consulta se realizó exitosamente";
        response.Data = voterList;
      }
      return response;
    }

    [HttpGet("{id}", Name = "GetVoter")]
    public Response GetById(int id)
    {
      var response = new Response
      {
        Success = false,
        Result = HttpStatusCode.NotFound,
        Message = "No se encontró información",
        Data = { }

      };
      var voter = _context.Voters.Find(id);
      if (voter == null)
      {
        return response;
      }
      voter.Country = _context.Countries.Find(voter.CountryId);
      voter.Department = _context.Departments.Find(voter.DepartmentId);
      voter.City = _context.Cities.Find(voter.CityId);
      voter.Commune = _context.Communes.Find(voter.CommuneId);
      voter.User = _context.DataUsers.Find(voter.UserId);
      voter.VotingPlace = _context.VotingPlaces.Find(voter.VotingPlaceId);
      voter.Genre = _context.Genres.Find(voter.GenreId);
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
        GenreId = voter.Genre.GenreId,
        GenreName = voter.Genre.Name,
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

      response.Success = true;
      response.Result = HttpStatusCode.OK;
      response.Message = "La consulta se realizó exitosamente";
      response.Data = voterView;

      return response;
    }

    [HttpPost]
    public async Task<Response> CreateAsync([FromBody] Voter voter)
    {
      if (voter == null)
      {
        return new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se envió información", Data = { } };
      }

      _context.Voters.Add(voter);
      try
      {
        _context.SaveChanges();
        voter.Country = _context.Countries.Find(voter.CountryId);
        voter.Department = _context.Departments.Find(voter.DepartmentId);
        voter.City = _context.Cities.Find(voter.CityId);
        voter.Commune = _context.Communes.Find(voter.CommuneId);
        voter.User = _context.DataUsers.Find(voter.UserId);
        voter.VotingPlace = _context.VotingPlaces.Find(voter.VotingPlaceId);
        voter.Genre = _context.Genres.Find(voter.GenreId);
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
          GenreId = voter.Genre.GenreId,
          GenreName = voter.Genre.Name,
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

        return new Response { Success = true, Result = HttpStatusCode.OK, Message = "El registro se guardó exitosamente", Data = voterView };
      }
      catch (Exception ex)
      {
        return new Response { Success = false, Result = HttpStatusCode.InternalServerError, Message = "Ocurrió un error al crear el registro", Data = { } };
      }
    }

    [HttpPut("{id}")]
    public Response Update(int id, [FromBody] Voter voter)
    {
      if (voter == null || voter.VoterId != id)
      {
        return new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se envió información", Data = { } };
      }

      var voterUpdate = _context.Voters.Find(id);
      if (voterUpdate == null)
      {
        return new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se encontró ningún registro", Data = { } };
      }

      voterUpdate.FirstName = voter.FirstName;
      voterUpdate.LastName = voter.LastName;
      voterUpdate.Document = voter.Document;
      voterUpdate.Address = voter.Address;
      voterUpdate.CountryId = voter.CountryId;
      voterUpdate.DepartmentId = voter.DepartmentId;
      voterUpdate.CityId = voter.CityId;
      voterUpdate.GenreId = voter.GenreId;
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
      try
      {
        _context.SaveChanges();
        voterUpdate.Country = _context.Countries.Find(voterUpdate.CountryId);
        voterUpdate.Department = _context.Departments.Find(voterUpdate.DepartmentId);
        voterUpdate.City = _context.Cities.Find(voterUpdate.CityId);
        voterUpdate.Commune = _context.Communes.Find(voterUpdate.CommuneId);
        voterUpdate.User = _context.DataUsers.Find(voterUpdate.UserId);
        voterUpdate.VotingPlace = _context.VotingPlaces.Find(voterUpdate.VotingPlaceId);
        voterUpdate.Genre = _context.Genres.Find(voterUpdate.GenreId);
        var voterView = new VoterViewModel
        {
          Id = voterUpdate.VoterId,
          FirstName = voterUpdate.FirstName,
          LastName = voterUpdate.LastName,
          Document = voterUpdate.Document,
          Address = voterUpdate.Address,
          CountryId = voterUpdate.Country.CountryId,
          CountryName = voterUpdate.Country.Name,
          DepartmentId = voterUpdate.Department.DepartmentId,
          DepartmentName = voterUpdate.Department.Name,
          CityId = voterUpdate.City.CityId,
          CityName = voterUpdate.City.Name,
          GenreId = voterUpdate.Genre.GenreId,
          GenreName = voterUpdate.Genre.Name,
          CellPhone = voterUpdate.CellPhone,
          Association = voterUpdate.Association,
          CommuneId = voterUpdate.Commune.CommuneId,
          Commune = voterUpdate.Commune.Name,
          DateOfBirth = voterUpdate.DateOfBirth,
          Email = voterUpdate.Email,
          Latitude = voterUpdate.Latitude,
          Longitude = voterUpdate.Longitude,
          Ocupation = voterUpdate.Ocupation,
          UserId = voterUpdate.User.UserId,
          UserName = voterUpdate.User.FirstName + " " + voterUpdate.User.LastName,
          VotingPlaceId = voterUpdate.VotingPlace.VotingPlaceId,
          VotingPlace = voterUpdate.VotingPlace.Name,
          WorkPlace = voterUpdate.WorkPlace,
          Observation = voterUpdate.Observation
        };

        return new Response { Success = true, Result = HttpStatusCode.OK, Message = "El registro se modificó exitosamente", Data = voterView };
      }
      catch (Exception)
      {
        return new Response { Success = false, Result = HttpStatusCode.InternalServerError, Message = "Ocurrió un error al modificar el registro", Data = { } };
      }
    }

    [HttpDelete("{id}")]
    public async Task<Response> DeleteAsync(int id)
    {
      var voter = _context.Voters.Find(id);
      if (voter == null)
      {
        return new Response { Success = false, Result = HttpStatusCode.NotFound, Message = "No se encontró ningún registro", Data = { } };
      }

      _context.Voters.Remove(voter);
      try
      {
        _context.SaveChanges();
        return new Response { Success = true, Result = HttpStatusCode.OK, Message = "El registro se borró exitosamente", Data = { } };
      }
      catch (Exception)
      {
        return new Response { Success = false, Result = HttpStatusCode.InternalServerError, Message = "Ocurrió un error al borrar el registro", Data = { } };
      }
    }
  }
}
