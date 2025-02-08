using Microsoft.AspNetCore.Mvc;
using EnerGovSolutionsAPI.Models;
using EnerGovSolutionsAPI.Repository;
using System.Net.WebSockets;
using Microsoft.Identity.Client;
namespace EnerGovSolutionsAPI.Controllers
{
    [ApiController]
    [Route("api[EnergovSolutions_Controller]")]
    public class EnerGovSolutions_Controller : ControllerBase
    {
        #region Employee Management
        public EnerGovSolutions_Controller() { }

        [HttpGet("")]
        public async Task<List<Employee>> GetemployeeList()
        {
            var result = await EnerGovSolutions_Repository.GetemployeeList();
            return result;
        }

        [HttpPost("{NewEmployee}")]
        public async Task<IActionResult> AddNewEmployee(Employee NewEmployee)
        {
            var result = await EnerGovSolutions_Repository.AddEmployee(NewEmployee);
            return result;
        }
        [HttpPut("{Selected_Employee}")]
        public async Task<IActionResult> UpdateEmployee(Employee Selected_Employee)
        {
            var result = await EnerGovSolutions_Repository.UpdateEmployee(Selected_Employee);
            return result;
        }
        [HttpDelete("{Selected_Employee}")]
        public async Task<IActionResult> DeleteEmployee(Employee Selected_Employee)
        {
               var result = await EnerGovSolutions_Repository.DeleteEmployee(Selected_Employee);
               return result;
        }
        #endregion
        #region Role Management
        [HttpGet("")]
        public async Task<List<Roles>> GetRoles()
        {
            var result = await EnerGovSolutions_Repository.GetRoles();
            return result;
        }

        [HttpPost("{NewRole}")]
        public async Task<IActionResult> AddRole(Roles NewRole)
        {
            var result = await EnerGovSolutions_Repository.AddRole(NewRole);
            return result;
        }

        [HttpPost("{role}")]
        public async Task<IActionResult> DeleteRole(Roles role)
        {
            var result = await EnerGovSolutions_Repository.DeleteRole(role);
            return result;
        }
    }
}
