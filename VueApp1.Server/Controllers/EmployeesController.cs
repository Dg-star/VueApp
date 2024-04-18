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
            Console.WriteLine(employees);
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetEmployee(int id)
        {
            var employee = await _context.Users.FindAsync(id);
            Console.WriteLine(employee);
            if (employee == null)
            {
                return NotFound();
            }
            // Явное приведение типа к Int32
            // TODO 
            employee.user_id = (int)(long)employee.user_id;
            employee.phone_number = (int)(long)employee.phone_number;
            employee.status_id = (int)(long)employee.status_id;
            employee.organization_id = (int)(long)employee.organization_id;

            Console.WriteLine(employee);
            return Ok(employee);
        }

    }
}
