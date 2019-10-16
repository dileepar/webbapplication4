using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Services
{
    public class StaffService
    {
        private readonly ApplicationDbContext dbContext;

        public StaffService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync(int page, string searchText)
        {
            var staff = await dbContext.Employees.FromSql("exec [dbo].[usp_Staff_Filter] @Page,@SearchText",
                new SqlParameter("Page", page),
                new SqlParameter("SearchText", searchText ?? SqlString.Null)).ToListAsync();

            return staff;
        }
    }
}
