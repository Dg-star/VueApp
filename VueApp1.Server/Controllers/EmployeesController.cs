using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Collections.Generic;
using System.Threading.Tasks;
using VueApp1.Server.Classes;



namespace VueApp1.Server.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeesController : ControllerBase
    {
        private readonly YourDbContext _context;

        public EmployeesController(IConfiguration configuration)
        {
            // Получаем строку подключения из IConfiguration
            string connectionString = configuration.GetConnectionString("ConnectionString");
            Console.WriteLine("запрос прошёл employee");
            // Используем строку подключения для настройки DbContext
            var options = new DbContextOptionsBuilder<YourDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            _context = new YourDbContext(options);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetEmployees()
        {
            var employees = await _context.Users.ToListAsync();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetEmployee(int id)
        {
            var employee = await _context.Users.FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }
            Console.WriteLine(employee);
            return Ok(employee);

        }
    }
}
