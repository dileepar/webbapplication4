using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly StaffService staffService;

        public StaffController(StaffService staffService)
        {
            this.staffService = staffService;
        }

        [HttpGet]
        public async Task<IEnumerable<Employee>> Get(int page, string searchText)
        {
            var staff = await staffService.GetEmployeesAsync(page, searchText);
            return staff;
        }
    }
}
