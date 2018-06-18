using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularASPNETCore2WebApiAuth.Data;
using AngularASPNETCore2WebApiAuth.Models.Entities;
using AngularASPNETCore2WebApiAuth.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularASPNETCore2WebApiAuth.Controllers
{
  [Route("api/[controller]")]
  [EnableCors("CorsPolicy")]
  [Authorize]
  public class DepartmentsController : Controller
  {
    private readonly ApplicationDbContext _context;

    public DepartmentsController(ApplicationDbContext context)
    {
      _context = context;
    }

    [HttpGet]
    public List<DepartmentViewModel> GetAll()
    {
      List<DepartmentViewModel> departmentList = new List<DepartmentViewModel>();
      var departments = _context.Departments.ToList();

      foreach (var department in departments)
      {
        department.Country = _context.Countries.Find(department.CountryId);
        var data = new DepartmentViewModel
        {
          Id = department.DepartmentId,
          Name = department.Name,
          CountryId = department.Country.CountryId,
          CountryName = department.Country.Name
        };
        departmentList.Add(data);
      }

      return departmentList;
    }

    [HttpGet("{id}", Name = "GetDepartment")]
    public IActionResult GetById(int id)
    {
      var item = _context.Departments.Find(id);
      if (item == null)
      {
        return NotFound();
      }
      item.Country = _context.Countries.Find(item.CountryId);
      var departmentView = new DepartmentViewModel
      {
        Id = item.CountryId,
        Name = item.Name,
        CountryId = item.Country.CountryId,
        CountryName = item.Country.Name
      };

      return Ok(departmentView);
    }

    [HttpPost]
    public IActionResult Create([FromBody] Department department)
    {
      if (department == null)
      {
        return BadRequest();
      }

      _context.Departments.Add(department);
      _context.SaveChanges();

      return CreatedAtRoute("GetDepartment", new { id = department.DepartmentId }, department);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Department department)
    {
      if (department == null || department.DepartmentId!= id)
      {
        return BadRequest();
      }

      var departmentUpdate = _context.Departments.Find(id);
      if (departmentUpdate == null)
      {
        return NotFound();
      }

      departmentUpdate.Name = department.Name;
      departmentUpdate.CountryId = department.CountryId; 


      _context.Departments.Update(departmentUpdate);
      _context.SaveChanges();
      return CreatedAtRoute("GetDepartment", new { id = departmentUpdate.CountryId }, departmentUpdate);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      var department = _context.Departments.Find(id);
      if (department == null)
      {
        return NotFound();
      }

      _context.Departments.Remove(department);
      _context.SaveChanges();
      return NoContent();
    }
  }
}
