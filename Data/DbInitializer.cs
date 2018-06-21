using AngularASPNETCore2WebApiAuth.Data;
using AngularASPNETCore2WebApiAuth.Models;
using AngularASPNETCore2WebApiAuth.Models.Entities;
using AngularASPNETCore2WebApiAuth.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace AngularASPNETCore2WebApiAuth.Data
{
  public static class DbInitializer
  {
    public static void Initialize(ApplicationDbContext context, IMapper mapper, UserManager<AppUser> userManager)
    {
      context.Database.EnsureCreated();
      if (!context.Genres.Any())
      {
        context.Genres.Add(new Genre { Name = "Masculino" });
        context.Genres.Add(new Genre { Name = "Femenino" });
        context.Genres.Add(new Genre { Name = "Sin especificar" });
        context.SaveChanges();
      }

      if (!context.Countries.Any())
      {
        context.Countries.Add(new Country { Name = "Colombia" });
        context.SaveChanges();
      }

      if (!context.Departments.Any())
      {
        context.Departments.Add(new Department { Name = "Amazonas", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Antioquia", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Arauca", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Atlántico", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Bolívar", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Boyacá", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Caldas", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Caquetá", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Casanare", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Cauca", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Cesar", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Chocó", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Córdoba", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Cundinamarca", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Güainia", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Guaviare", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Huila", CountryId = 1 });
        context.Departments.Add(new Department { Name = "La Guajira", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Magdalena", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Meta", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Nariño", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Norte de Santander", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Putumayo", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Quindio", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Risaralda", CountryId = 1 });
        context.Departments.Add(new Department { Name = "San Andrés y Providencia", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Santander", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Sucre", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Tolima", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Valle del Cauca", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Vaupés", CountryId = 1 });
        context.Departments.Add(new Department { Name = "Vichada", CountryId = 1 });
        context.SaveChanges();
      }

      if (!context.Cities.Any())
      {
        context.Cities.Add(new City { Name = "Ábrego", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Arboledas", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Bochalema", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Bucarasica", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Cáchira", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Cácota", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Chinácota", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Chitagá", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Convención", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Cúcuta", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Cucutilla", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Durania", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "El Carmen", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "El Tarra", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "El Zulia", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Gramalote", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Hacarí", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Herrán", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "La Esperanza", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "La Playa", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Labateca", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Los Patios", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Lourdes", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Mutiscua", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Ocaña", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Pamplona", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Pamplonita", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Puerto Santander", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Ragonvalia", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Salazar", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "San Calixto", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "San Cayetano", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Santiago", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Sardinata", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Silos", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Teorama", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Tibú", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Toledo", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Villa Caro", CountryId = 1, DepartmentId = 10 });
        context.Cities.Add(new City { Name = "Villa del Rosario", CountryId = 1, DepartmentId = 10 });
        context.SaveChanges();
      }

      if (!context.DataUsers.Any())
      {
        context.DataUsers.Add(new User { CountryId = 1, DepartmentId = 10, CityId = 30, Address = "Cúcuta, Norte de Santander", FirstName = "Administrador", LastName = " - Red", GenreId = 1, Phone = "3123563403", Photo = "", UserName = "joer04011992@gmail.com", Password = "itccolp23", RoleUser = "Administrador" });
        context.SaveChanges();
      }

      if (!context.Communes.Any())
      {
        context.Communes.Add(new Commune { Name = "1", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.Communes.Add(new Commune { Name = "2", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.Communes.Add(new Commune { Name = "3", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.Communes.Add(new Commune { Name = "4", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.Communes.Add(new Commune { Name = "5", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.Communes.Add(new Commune { Name = "6", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.Communes.Add(new Commune { Name = "7", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.Communes.Add(new Commune { Name = "8", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.Communes.Add(new Commune { Name = "9", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.Communes.Add(new Commune { Name = "10", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.SaveChanges();
      }

      if (!context.RedUsers.Any())
      {
        context.RedUsers.Add(new RedUser { Name = "Jéfe" });
        context.RedUsers.Add(new RedUser { Name = "Enlace" });
        context.RedUsers.Add(new RedUser { Name = "Coordinador" });
        context.RedUsers.Add(new RedUser { Name = "Líder" });
        context.RedUsers.Add(new RedUser { Name = "Votante" });
        context.RedUsers.Add(new RedUser { Name = "Administrador" });
        context.SaveChanges();
      }

      if (!context.VotingPlaces.Any())
      {
        context.VotingPlaces.Add(new VotingPlace { Code = "0001", Name = "La Maria", CountryId = 1, DepartmentId = 10, CityId = 1 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0002", Name = "El Higueron", CountryId = 1, DepartmentId = 10, CityId = 1 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0003", Name = "La Arenosa", CountryId = 1, DepartmentId = 10, CityId = 1 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0004", Name = "Montecristo", CountryId = 1, DepartmentId = 10, CityId = 1 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0005", Name = "El Tarra", CountryId = 1, DepartmentId = 10, CityId = 1 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0006", Name = "Casitas", CountryId = 1, DepartmentId = 10, CityId = 1 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0007", Name = "Los Indios", CountryId = 1, DepartmentId = 10, CityId = 1 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0008", Name = "El Guamal", CountryId = 1, DepartmentId = 10, CityId = 1 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0009", Name = "Hoyo Pilon", CountryId = 1, DepartmentId = 10, CityId = 1 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0010", Name = "San Jose", CountryId = 1, DepartmentId = 10, CityId = 1 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0011", Name = "El Loro", CountryId = 1, DepartmentId = 10, CityId = 1 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0012", Name = "El Cairo", CountryId = 1, DepartmentId = 10, CityId = 1 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0013", Name = "Playoncitos", CountryId = 1, DepartmentId = 10, CityId = 1 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0014", Name = "El Tabaco", CountryId = 1, DepartmentId = 10, CityId = 1 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0015", Name = "Capitanlargo", CountryId = 1, DepartmentId = 10, CityId = 1 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0016", Name = "Canoas", CountryId = 1, DepartmentId = 10, CityId = 1 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0017", Name = "El Llanon", CountryId = 1, DepartmentId = 10, CityId = 1 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0018", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 1 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0019", Name = "La Sierra", CountryId = 1, DepartmentId = 10, CityId = 1 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0020", Name = "San Vicente", CountryId = 1, DepartmentId = 10, CityId = 1 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0021", Name = "Gaira", CountryId = 1, DepartmentId = 10, CityId = 1 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0022", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 22 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0023", Name = "Uvito", CountryId = 1, DepartmentId = 10, CityId = 22 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0024", Name = "La Uvita", CountryId = 1, DepartmentId = 10, CityId = 22 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0025", Name = "Cinera", CountryId = 1, DepartmentId = 10, CityId = 22 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0026", Name = "Barrientos", CountryId = 1, DepartmentId = 10, CityId = 22 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0027", Name = "Villa Sucre", CountryId = 1, DepartmentId = 10, CityId = 22 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0028", Name = "Los Molinos", CountryId = 1, DepartmentId = 10, CityId = 22 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0029", Name = "Guzaman", CountryId = 1, DepartmentId = 10, CityId = 22 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0030", Name = "Castro", CountryId = 1, DepartmentId = 10, CityId = 22 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0031", Name = "Monterredondo", CountryId = 1, DepartmentId = 10, CityId = 23 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0032", Name = "Espejuelos (nebraska)", CountryId = 1, DepartmentId = 10, CityId = 23 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0033", Name = "Portachuelo", CountryId = 1, DepartmentId = 10, CityId = 23 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0034", Name = "La Donjuana", CountryId = 1, DepartmentId = 10, CityId = 23 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0035", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 23 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0036", Name = "La Curva", CountryId = 1, DepartmentId = 10, CityId = 24 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0037", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 24 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0038", Name = "La Sanjuana", CountryId = 1, DepartmentId = 10, CityId = 24 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0039", Name = "Aguablanca", CountryId = 1, DepartmentId = 10, CityId = 24 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0040", Name = "Las Cuadras", CountryId = 1, DepartmentId = 10, CityId = 24 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0041", Name = "Laguna De Oriente", CountryId = 1, DepartmentId = 10, CityId = 25 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0042", Name = "El Manzano", CountryId = 1, DepartmentId = 10, CityId = 25 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0043", Name = "Ramirez", CountryId = 1, DepartmentId = 10, CityId = 25 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0044", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 25 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0045", Name = "La Union", CountryId = 1, DepartmentId = 10, CityId = 25 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0046", Name = "El Lucero", CountryId = 1, DepartmentId = 10, CityId = 25 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0047", Name = "Los Mangos", CountryId = 1, DepartmentId = 10, CityId = 25 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0048", Name = "La Vega", CountryId = 1, DepartmentId = 10, CityId = 25 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0049", Name = "San Jose De La Montaña", CountryId = 1, DepartmentId = 10, CityId = 25 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0050", Name = "La Carrera", CountryId = 1, DepartmentId = 10, CityId = 25 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0051", Name = "Primavera", CountryId = 1, DepartmentId = 10, CityId = 25 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0052", Name = "Targuala", CountryId = 1, DepartmentId = 10, CityId = 26 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0053", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 26 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0054", Name = "Nueva Donjuana", CountryId = 1, DepartmentId = 10, CityId = 27 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0055", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 27 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0056", Name = "Presidente", CountryId = 1, DepartmentId = 10, CityId = 28 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0057", Name = "El Porvenir", CountryId = 1, DepartmentId = 10, CityId = 28 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0058", Name = "Chucarima", CountryId = 1, DepartmentId = 10, CityId = 28 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0059", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 28 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0060", Name = "Tane", CountryId = 1, DepartmentId = 10, CityId = 28 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0061", Name = "Llano Grande", CountryId = 1, DepartmentId = 10, CityId = 28 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0062", Name = "El Alisal", CountryId = 1, DepartmentId = 10, CityId = 28 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0063", Name = "Cornejo", CountryId = 1, DepartmentId = 10, CityId = 28 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0064", Name = "Guamal", CountryId = 1, DepartmentId = 10, CityId = 29 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0065", Name = "Mesa Rica", CountryId = 1, DepartmentId = 10, CityId = 29 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0066", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 29 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0067", Name = "Los Balcones", CountryId = 1, DepartmentId = 10, CityId = 29 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0068", Name = "La Trinidad", CountryId = 1, DepartmentId = 10, CityId = 29 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0069", Name = "Soledad", CountryId = 1, DepartmentId = 10, CityId = 29 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0070", Name = "Honduras", CountryId = 1, DepartmentId = 10, CityId = 29 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0071", Name = "Miraflores", CountryId = 1, DepartmentId = 10, CityId = 29 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0072", Name = "Cartagenita", CountryId = 1, DepartmentId = 10, CityId = 29 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0073", Name = "El Hoyo", CountryId = 1, DepartmentId = 10, CityId = 29 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0074", Name = "Las Mercedes", CountryId = 1, DepartmentId = 10, CityId = 29 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0075", Name = "Saphadana", CountryId = 1, DepartmentId = 10, CityId = 29 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0076", Name = "La Libertad", CountryId = 1, DepartmentId = 10, CityId = 29 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0077", Name = "San Jose De Las Pitas", CountryId = 1, DepartmentId = 10, CityId = 29 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0078", Name = "Limoncito", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0079", Name = "Colegio Sagrado Corazon De Jesus", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0080", Name = "Colegio Basico Club De Leones No 29", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0081", Name = "Santos Apostoles Sede Kennedy", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0082", Name = "Colegio Julio Perez Ferrero", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0083", Name = "Colegio Pablo Correa Sede Club De Tenis", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0084", Name = "Colegio Oriental No. 26", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0085", Name = "Colegio concejo De Cucuta", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0086", Name = "Salesiano Sede Fco De Paula", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0087", Name = "Palmarito", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0088", Name = "Colegio San Jose Sede Mercedes Abrego", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0089", Name = "Colegio Simon Bolivar", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0090", Name = "Inst Educativa San Jose", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0091", Name = "I.e.el Rodeo", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0092", Name = "El Carmen De Tonchala", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0093", Name = "Colegio La Salle", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0094", Name = "Inem", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0095", Name = "Colegio Basico Camilo Daza", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0096", Name = "Santo Angel Sede Jose Eusebio", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0097", Name = "Puerto Villamizar", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0098", Name = "Esc.marco Fidel Suarez", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0099", Name = "Col Eustorgio Colmenares Bauti", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0100", Name = "Col Hermano Rodulfo Eloy", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0101", Name = "Ricaurte", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0102", Name = "Mercedes Abrego Sede Jardin Na", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0103", Name = "Gremios Unidos Sede Simon Boli", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0104", Name = "Col Mariano Ospina Perez", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0105", Name = "Col Garcia Herreros Sede Esc 2", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0106", Name = "Carcel", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0107", Name = "Escuela San Mateo", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0108", Name = "Col Andres Bello Sede Laura Vi", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0109", Name = "Col Rafael Uribe Uribe", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0110", Name = "Aguaclara", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0111", Name = "Colegio Antonio Nariño", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0112", Name = "I.e.mon.jaime Prieto Amaya", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0113", Name = "Col San Bartolome", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0114", Name = "C.manuel Antonio Fernandez De", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0115", Name = "Col.francisco Jose Caldas", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0116", Name = "Inem Sede Miguel Muller", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0117", Name = "Esc.no38 Teodoro Gutierrez C.", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0118", Name = "Alejandro Gutierrez Sede San J", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0119", Name = "La Buena Esperanza", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0120", Name = "Col Sagrado Sede Antonia Santo", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0121", Name = "Colegio Padre Luis Variara", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0122", Name = "Col Toledo Plata", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0123", Name = "Col Ntra Sra De Belen 23 Varon", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0124", Name = "San Pedro", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0125", Name = "Instituto Bilingue Londres", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0126", Name = "Col Andres Bello", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0127", Name = "Esc.comuneros Nro 33", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0128", Name = "Col Luis Carlos Galan Sarmient", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0129", Name = "Banco De Arena", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0130", Name = "Col Pablo Correa Sede Maria Au	", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0131", Name = "Escuela El Cerrito", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0132", Name = "Carlos Ramirez Sede Ntra Sra D", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0133", Name = "San Faustino", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0134", Name = "Seminario Menor", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0135", Name = "Guaimaral S.hermogenes Maza	", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0136", Name = "Col Buenos Aires", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0137", Name = "Col.basico Los Alpes", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0138", Name = "Carcel De Mujeres", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0139", Name = "Fco Jose De Caldas Sede San Pe", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0140", Name = "Col Municipal Aeropuerto", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0141", Name = "Inst Tecn Carlos Ramirez Paris", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0142", Name = "Guaramito", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0143", Name = "Inst Tec Industrial Salesiano", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0144", Name = "Col.carlos Perez Escalante", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0145", Name = "Col Integrado Juan Atalaya", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0146", Name = "Col Ntra Sra De Belen La Divin", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0147", Name = "Club De Leones Sede I.e.bocono", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0148", Name = "Col.basico Guaimaral Nro 25", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0149", Name = "Col San Jose De Peralta", CountryId = 1, DepartmentId = 10, CityId = 30 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0150", Name = "Normal Maria Auxiliadora", CountryId = 1, DepartmentId = 10, CityId = 30 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0151", Name = "San Jose De La Montaña", CountryId = 1, DepartmentId = 10, CityId = 31 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0152", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 31 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0153", Name = "Puente Julio Arboleda", CountryId = 1, DepartmentId = 10, CityId = 31 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0154", Name = "La Trinidad", CountryId = 1, DepartmentId = 10, CityId = 32 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0155", Name = "Hatoviejo", CountryId = 1, DepartmentId = 10, CityId = 32 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0156", Name = "La Cuchilla", CountryId = 1, DepartmentId = 10, CityId = 32 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0157", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 32 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0158", Name = "Las Aguilas", CountryId = 1, DepartmentId = 10, CityId = 33 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0159", Name = "Astillero", CountryId = 1, DepartmentId = 10, CityId = 33 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0160", Name = "Santa Ines", CountryId = 1, DepartmentId = 10, CityId = 33 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0161", Name = "La Quiebra", CountryId = 1, DepartmentId = 10, CityId = 33 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0162", Name = "Bellaluz", CountryId = 1, DepartmentId = 10, CityId = 33 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0163", Name = "Quebrada Arriba", CountryId = 1, DepartmentId = 10, CityId = 33 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0164", Name = "La Estrella", CountryId = 1, DepartmentId = 10, CityId = 33 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0165", Name = "Las Vegas", CountryId = 1, DepartmentId = 10, CityId = 33 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0166", Name = "El Zul", CountryId = 1, DepartmentId = 10, CityId = 33 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0167", Name = "Pajitas", CountryId = 1, DepartmentId = 10, CityId = 33 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0168", Name = "Culebrita", CountryId = 1, DepartmentId = 10, CityId = 33 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0169", Name = "Santo Domingo", CountryId = 1, DepartmentId = 10, CityId = 33 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0170", Name = "La Pelota", CountryId = 1, DepartmentId = 10, CityId = 33 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0171", Name = "Bobali", CountryId = 1, DepartmentId = 10, CityId = 33 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0172", Name = "Quebrada Honda", CountryId = 1, DepartmentId = 10, CityId = 33 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0173", Name = "La Osa", CountryId = 1, DepartmentId = 10, CityId = 33 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0174", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 33 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0175", Name = "Maracaibo", CountryId = 1, DepartmentId = 10, CityId = 33 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0176", Name = "Guamalito", CountryId = 1, DepartmentId = 10, CityId = 33 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0177", Name = "Las Vegas De Motilonia", CountryId = 1, DepartmentId = 10, CityId = 33 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0178", Name = "El Cobre", CountryId = 1, DepartmentId = 10, CityId = 33 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0179", Name = "Nueva Granada (bellavista)", CountryId = 1, DepartmentId = 10, CityId = 34 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0180", Name = "El Paso", CountryId = 1, DepartmentId = 10, CityId = 34 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0181", Name = "Playa Cotiza", CountryId = 1, DepartmentId = 10, CityId = 34 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0182", Name = "Oru", CountryId = 1, DepartmentId = 10, CityId = 34 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0183", Name = "Filo El Gringo", CountryId = 1, DepartmentId = 10, CityId = 34 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0184", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 34 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0185", Name = "Palmas De Vino", CountryId = 1, DepartmentId = 10, CityId = 34 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0186", Name = "San Miguel", CountryId = 1, DepartmentId = 10, CityId = 35 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0187", Name = "Campo Alicia", CountryId = 1, DepartmentId = 10, CityId = 35 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0188", Name = "Pan De Azucar", CountryId = 1, DepartmentId = 10, CityId = 35 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0189", Name = "Encerraderos", CountryId = 1, DepartmentId = 10, CityId = 35 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0190", Name = "Astilleros", CountryId = 1, DepartmentId = 10, CityId = 35 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0191", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 35 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0192", Name = "El Rosario", CountryId = 1, DepartmentId = 10, CityId = 36 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0193", Name = "El Zumbador", CountryId = 1, DepartmentId = 10, CityId = 36 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0194", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 36 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0195", Name = "San Isidro", CountryId = 1, DepartmentId = 10, CityId = 36 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0196", Name = "Martinez", CountryId = 1, DepartmentId = 10, CityId = 37 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0197", Name = "Astilleros", CountryId = 1, DepartmentId = 10, CityId = 37 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0198", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 37 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0199", Name = "San Jose Del Tarra", CountryId = 1, DepartmentId = 10, CityId = 37 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0200", Name = "Buenos Aires", CountryId = 1, DepartmentId = 10, CityId = 37 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0201", Name = "Agua Blanca", CountryId = 1, DepartmentId = 10, CityId = 37 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0202", Name = "Maracaibo", CountryId = 1, DepartmentId = 10, CityId = 37 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0203", Name = "San Miguel", CountryId = 1, DepartmentId = 10, CityId = 37 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0204", Name = "Honda Sur", CountryId = 1, DepartmentId = 10, CityId = 38 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0205", Name = "Siberia", CountryId = 1, DepartmentId = 10, CityId = 38 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0206", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 38 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0207", Name = "La Pedregoza", CountryId = 1, DepartmentId = 10, CityId = 21 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0208", Name = "La Raya", CountryId = 1, DepartmentId = 10, CityId = 21 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0209", Name = "Vijagual", CountryId = 1, DepartmentId = 10, CityId = 21 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0210", Name = "Pueblo Nuevo", CountryId = 1, DepartmentId = 10, CityId = 21 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0211", Name = "La Quiebra", CountryId = 1, DepartmentId = 10, CityId = 21 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0212", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 21 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0213", Name = "Los Cedros", CountryId = 1, DepartmentId = 10, CityId = 21 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0214", Name = "Leon Xiii", CountryId = 1, DepartmentId = 10, CityId = 21 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0215", Name = "Villa Maria", CountryId = 1, DepartmentId = 10, CityId = 21 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0216", Name = "Tropezon", CountryId = 1, DepartmentId = 10, CityId = 21 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0217", Name = "Jurisdicciones De San Pedro", CountryId = 1, DepartmentId = 10, CityId = 21 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0218", Name = "Campo Alegre", CountryId = 1, DepartmentId = 10, CityId = 21 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0219", Name = "Los Planes", CountryId = 1, DepartmentId = 10, CityId = 21 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0220", Name = "Curasica", CountryId = 1, DepartmentId = 10, CityId = 20 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0221", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 20 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0222", Name = "El Cincho (la Vega De San Ant", CountryId = 1, DepartmentId = 10, CityId = 20 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0223", Name = "Aspasica", CountryId = 1, DepartmentId = 10, CityId = 20 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0224", Name = "Maciegas", CountryId = 1, DepartmentId = 10, CityId = 20 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0225", Name = "La Cuchilla", CountryId = 1, DepartmentId = 10, CityId = 19 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0226", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 19 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0227", Name = "Santa Maria", CountryId = 1, DepartmentId = 10, CityId = 19 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0228", Name = "Mutis", CountryId = 1, DepartmentId = 10, CityId = 9 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0229", Name = "Hogar Infantil El Manantial", CountryId = 1, DepartmentId = 10, CityId = 9 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0230", Name = "Col.basico Patios Centro No 1", CountryId = 1, DepartmentId = 10, CityId = 9 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0231", Name = "Colegio Fe Y Alegria", CountryId = 1, DepartmentId = 10, CityId = 9 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0232", Name = "Colegio San Tarcisio", CountryId = 1, DepartmentId = 10, CityId = 9 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0233", Name = "Comfanorte", CountryId = 1, DepartmentId = 10, CityId = 9 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0234", Name = "Inst. Tecnico Municipal", CountryId = 1, DepartmentId = 10, CityId = 9 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0235", Name = "Colegio 11 De Noviembre", CountryId = 1, DepartmentId = 10, CityId = 9 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0236", Name = "La Garita", CountryId = 1, DepartmentId = 10, CityId = 9 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0237", Name = "Col Patio Centro No.2", CountryId = 1, DepartmentId = 10, CityId = 9 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0238", Name = "Escuela Buena Esperanza", CountryId = 1, DepartmentId = 10, CityId = 9 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0239", Name = "Esc. Sabana", CountryId = 1, DepartmentId = 10, CityId = 9 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0240", Name = "Colegio Llanitos", CountryId = 1, DepartmentId = 10, CityId = 9 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0241", Name = "Esc. Pisarreal", CountryId = 1, DepartmentId = 10, CityId = 9 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0242", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 2 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0243", Name = "La Laguna", CountryId = 1, DepartmentId = 10, CityId = 3 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0244", Name = "Sucre", CountryId = 1, DepartmentId = 10, CityId = 3 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0245", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 3 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0246", Name = "Cancha Marabel", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0247", Name = "Las Liscas", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0248", Name = "Escuela Cristo Rey", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0249", Name = "Buenavista", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0250", Name = "Instituto Tecnico Industrial", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0251", Name = "La Floresta", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0252", Name = "Escuela Normal De Señoritas", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0253", Name = "Aguas Claras", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0254", Name = "Quebrada De La Esperanza", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0255", Name = "Escuela Marabel", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0256", Name = "Palogrande", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0257", Name = "Col Nal Jose Eusebio Caro", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0258", Name = "Portachuelo", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0259", Name = "Sede David Haddad Salcedo", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0260", Name = "Espiritusanto", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0261", Name = "Colegio Alfonso Lopez", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0262", Name = "Llano De Los Trigos", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0263", Name = "Escuela Adolfo Milanes", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0264", Name = "Otare", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0265", Name = "Escuela Santa Clara", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0266", Name = "Las Chircas", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0267", Name = "Complejo Historico", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0268", Name = "Agua De La Virgen", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0269", Name = "Venadillo", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0270", Name = "Escuela Juan Xxiii", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0271", Name = "La Ermita", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0272", Name = "Carcel", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0273", Name = "Pueblo Nuevo", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0274", Name = "Polideportivo Cristo Rey", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0275", Name = "Alto De Los Patios", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0276", Name = "Escuela Jose Antonio Galan", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0277", Name = "Mariquita", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0278", Name = "Concentracion Angelino Duran", CountryId = 1, DepartmentId = 10, CityId = 4 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0279", Name = "Cerro De Las Flores", CountryId = 1, DepartmentId = 10, CityId = 4 });
     
        context.VotingPlaces.Add(new VotingPlace { Code = "0280", Name = "Negavita", CountryId = 1, DepartmentId = 10, CityId = 5 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0281", Name = "La Casona-universidad Pamplon", CountryId = 1, DepartmentId = 10, CityId = 5 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0282", Name = "Carcel", CountryId = 1, DepartmentId = 10, CityId = 5 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0283", Name = "Concentracion Basica Galan", CountryId = 1, DepartmentId = 10, CityId = 5 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0284", Name = "El Rosario Unipamplona", CountryId = 1, DepartmentId = 10, CityId = 5 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0285", Name = "I. S. E. R.", CountryId = 1, DepartmentId = 10, CityId = 5 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0286", Name = "Laureano Gomez", CountryId = 1, DepartmentId = 10, CityId = 5 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0287", Name = "Colegio Provincial San Jose", CountryId = 1, DepartmentId = 10, CityId = 5 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0288", Name = "Colegio Cristo Rey", CountryId = 1, DepartmentId = 10, CityId = 5 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0289", Name = "Sede Gabriela Mistral Col.pro", CountryId = 1, DepartmentId = 10, CityId = 5 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0290", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 6 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0291", Name = "El Diamante", CountryId = 1, DepartmentId = 10, CityId = 6 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0292", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 7 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0293", Name = "Caliches", CountryId = 1, DepartmentId = 10, CityId = 8 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0294", Name = "Cañuelal", CountryId = 1, DepartmentId = 10, CityId = 8 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0295", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 8 });
     
        context.VotingPlaces.Add(new VotingPlace { Code = "0296", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 10 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0297", Name = "San Antonio", CountryId = 1, DepartmentId = 10, CityId = 10 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0298", Name = "El Zulia", CountryId = 1, DepartmentId = 10, CityId = 10 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0299", Name = "Campo Nuevo", CountryId = 1, DepartmentId = 10, CityId = 10 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0300", Name = "El Carmen De Nazareth", CountryId = 1, DepartmentId = 10, CityId = 10 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0301", Name = "San Jose De Avila", CountryId = 1, DepartmentId = 10, CityId = 10 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0302", Name = "Montecristo", CountryId = 1, DepartmentId = 10, CityId = 10 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0303", Name = "La Laguna", CountryId = 1, DepartmentId = 10, CityId = 10 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0304", Name = "Alto De Angulo", CountryId = 1, DepartmentId = 10, CityId = 10 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0305", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 18 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0306", Name = "San Juan", CountryId = 1, DepartmentId = 10, CityId = 18 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0307", Name = "Mesallana", CountryId = 1, DepartmentId =10, CityId = 18 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0308", Name = "Mediaguita", CountryId = 1, DepartmentId = 10, CityId = 18 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0309", Name = "Guaduales", CountryId = 1, DepartmentId = 10, CityId = 18 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0310", Name = "La Cristalina", CountryId = 1, DepartmentId = 10, CityId = 18 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0311", Name = "Casas Viejas", CountryId = 1, DepartmentId = 10, CityId = 18 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0312", Name = "San Jeronimo", CountryId = 1, DepartmentId = 10, CityId = 18 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0313", Name = "Algarrobos", CountryId = 1, DepartmentId = 10, CityId = 18 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0314", Name = "Santa Catalina", CountryId = 1, DepartmentId = 10, CityId = 18 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0315", Name = "Quebrada Grande", CountryId = 1, DepartmentId = 10, CityId = 18 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0316", Name = "San Javier", CountryId = 1, DepartmentId = 10, CityId = 18 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0317", Name = "El Espejo", CountryId = 1, DepartmentId = 10, CityId = 18 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0318", Name = "La Quina", CountryId = 1, DepartmentId = 10, CityId = 18 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0319", Name = "Banderas", CountryId = 1, DepartmentId = 10, CityId = 18 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0320", Name = "El Caracol", CountryId = 1, DepartmentId = 10, CityId = 18 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0321", Name = "Palmarito", CountryId = 1, DepartmentId = 10, CityId = 18 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0322", Name = "Puente Real", CountryId = 1, DepartmentId = 10, CityId = 18 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0323", Name = "Urimaco", CountryId = 1, DepartmentId = 10, CityId = 11 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0324", Name = "Ayacucho", CountryId = 1, DepartmentId = 10, CityId = 11 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0325", Name = "Cornejo", CountryId = 1, DepartmentId = 10, CityId = 11 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0326", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 11 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0327", Name = "La Cacahuala", CountryId = 1, DepartmentId = 10, CityId = 12 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0328", Name = "Los Naranjos", CountryId = 1, DepartmentId = 10, CityId = 12 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0329", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 12 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0330", Name = "Paramillo", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0331", Name = "La Esmeralda", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0332", Name = "Fatima", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0333", Name = "La Victoria", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0334", Name = "Guamo San Miguel", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0335", Name = "El Vesubio", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0336", Name = "Balsamina", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0337", Name = "San Martin De Loba", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0338", Name = "San Isidro", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0339", Name = "Cascajal", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0340", Name = "Las Mercedes", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0341", Name = "Las Mesas", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0342", Name = "La Cristalina", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0343", Name = "Jordancito", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0344", Name = "Encerraderos", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0345", Name = "El Carmen", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0346", Name = "San Roque", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0347", Name = "San Luis", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0348", Name = "Campo Rico", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0349", Name = "Luis Vero", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0350", Name = "Rio Nuevo", CountryId = 1, DepartmentId = 10, CityId = 13 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0351", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 13 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0352", Name = "Belen", CountryId = 1, DepartmentId = 10, CityId = 14 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0353", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 14 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0354", Name = "La Laguna", CountryId = 1, DepartmentId = 10, CityId = 14 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0355", Name = "Babega", CountryId = 1, DepartmentId = 10, CityId = 14 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0356", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 15 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0357", Name = "Ramirez", CountryId = 1, DepartmentId = 10, CityId = 15 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0358", Name = "El Juncal", CountryId = 1, DepartmentId = 10, CityId = 15 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0359", Name = "El Aserrio", CountryId = 1, DepartmentId = 10, CityId = 15 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0360", Name = "Fronteras De Teorama", CountryId = 1, DepartmentId = 10, CityId = 15 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0361", Name = "Rio De Oro", CountryId = 1, DepartmentId = 10, CityId = 15 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0362", Name = "La Cecilia", CountryId = 1, DepartmentId = 10, CityId = 15 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0363", Name = "Juridicciones", CountryId = 1, DepartmentId = 10, CityId = 15 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0364", Name = "San Pablo", CountryId = 1, DepartmentId = 10, CityId = 15 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0365", Name = "San Juancito", CountryId = 1, DepartmentId = 10, CityId = 15 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0366", Name = "La Llana O La Finaria", CountryId = 1, DepartmentId = 10, CityId = 16 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0367", Name = "Vetas De Oriente", CountryId = 1, DepartmentId = 10, CityId = 16 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0368", Name = "La Angalia", CountryId = 1, DepartmentId = 10, CityId = 16 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0369", Name = "Tres Bocas", CountryId = 1, DepartmentId = 10, CityId = 16 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0370", Name = "Barco La Silla", CountryId = 1, DepartmentId = 10, CityId = 16 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0371", Name = "Reyes (campo Dos)", CountryId = 1, DepartmentId = 10, CityId = 16 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0372", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 16 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0373", Name = "Pacelli", CountryId = 1, DepartmentId = 10, CityId = 16 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0374", Name = "La Gabarra", CountryId = 1, DepartmentId = 10, CityId = 16 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0375", Name = "Versalles", CountryId = 1, DepartmentId = 10, CityId = 16 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0376", Name = "Campo Giles", CountryId = 1, DepartmentId = 10, CityId = 16 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0377", Name = "Rio De Oro", CountryId = 1, DepartmentId = 10, CityId = 16 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0378", Name = "Aeropuerto La Pista", CountryId = 1, DepartmentId = 10, CityId = 16 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0379", Name = "Petrolea", CountryId = 1, DepartmentId = 10, CityId = 16 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0380", Name = "La Mesa", CountryId = 1, DepartmentId = 10, CityId = 17 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0381", Name = "Samore", CountryId = 1, DepartmentId = 10, CityId = 17 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0382", Name = "San Alberto", CountryId = 1, DepartmentId = 10, CityId = 17 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0383", Name = "Gibraltar (rio Cobaria)", CountryId = 1, DepartmentId = 10, CityId = 17 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0384", Name = "Roman", CountryId = 1, DepartmentId = 10, CityId = 17 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0385", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 17 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0386", Name = "La Union", CountryId = 1, DepartmentId = 10, CityId = 17 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0387", Name = "Margua", CountryId = 1, DepartmentId = 10, CityId = 17 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0388", Name = "La Loma", CountryId = 1, DepartmentId = 10, CityId = 17 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0389", Name = "San Bernardo Bata", CountryId = 1, DepartmentId = 10, CityId = 17 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0390", Name = "Alto Del Pozo", CountryId = 1, DepartmentId = 10, CityId = 39 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0391", Name = "Puesto Cabecera Municipal", CountryId = 1, DepartmentId = 10, CityId = 39 });

        context.VotingPlaces.Add(new VotingPlace { Code = "0392", Name = "Ctro De Integracion Ciud", CountryId = 1, DepartmentId = 10, CityId = 40 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0393", Name = "Escuela San Martin", CountryId = 1, DepartmentId = 10, CityId = 40 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0394", Name = "Colegio Montevideo Ii", CountryId = 1, DepartmentId = 10, CityId = 40 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0395", Name = "Colegio General Santander", CountryId = 1, DepartmentId = 10, CityId = 40 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0396", Name = "Mega Colegio La Frontera", CountryId = 1, DepartmentId = 10, CityId = 40 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0397", Name = "La Uchema", CountryId = 1, DepartmentId = 10, CityId = 40 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0398", Name = "Colegio San Pedro La Palmita", CountryId = 1, DepartmentId = 10, CityId = 40 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0399", Name = "Colegio Manuel Antonio Rueda", CountryId = 1, DepartmentId = 10, CityId = 40 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0400", Name = "Gimnacio Campestre", CountryId = 1, DepartmentId = 10, CityId = 40 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0401", Name = "Salon Comunal Trapiches", CountryId = 1, DepartmentId = 10, CityId = 40 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0402", Name = "Esc. Fco. De Paula Santander", CountryId = 1, DepartmentId = 10, CityId = 40 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0403", Name = "Colegio Pbro Alvaro Suarez", CountryId = 1, DepartmentId = 10, CityId = 40 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0404", Name = "Esc. Policarpa Salavarrieta", CountryId = 1, DepartmentId = 10, CityId = 40 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0405", Name = "Palogordo", CountryId = 1, DepartmentId = 10, CityId = 40 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0406", Name = "Colegio Luis Gabriel Castro", CountryId = 1, DepartmentId = 10, CityId = 40 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0407", Name = "Juan Frio", CountryId = 1, DepartmentId = 10, CityId = 40 });
        context.VotingPlaces.Add(new VotingPlace { Code = "0408", Name = "Escuela Veinte De Julio", CountryId = 1, DepartmentId = 10, CityId = 40 });

        context.SaveChanges();
      }

      context.SaveChanges();

      SeedUsers(userManager, mapper);
    }

    public static void SeedUsers(UserManager<AppUser> userManager, IMapper mapper)
    {
      if (userManager.FindByEmailAsync("joer04011992@gmail.com").Result == null)
      {
        var user1 = mapper.Map<AppUser>(new RegistrationViewModel { FirstName = "Administrador", LastName = " - Red", Email = "joer04011992@gmail.com", Location = "", Password = "itccolp23" });

        IdentityResult result = userManager.CreateAsync
        (user1, "itccolp23").Result;
      }


      if (userManager.FindByEmailAsync("ingeramirez0401@gmail.com").Result == null)
      {
        var user2 = mapper.Map<AppUser>(new RegistrationViewModel { FirstName = "Joel", LastName = "Ramirez", Email = "ingeramirez0401@gmail.com", Location = "", Password = "itccolp23" });

        IdentityResult result = userManager.CreateAsync
        (user2, "itccolp23").Result;
      }
    }
  }
}
