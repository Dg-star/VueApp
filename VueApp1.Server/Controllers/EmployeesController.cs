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
        private bool EmployeeExists(int id)
        {
            return _context.Users.Any(e => e.user_id == id);
        }
        public EmployeesController(IConfiguration configuration)
        {
            // �������� ������ ����������� �� IConfiguration
            string connectionString = configuration.GetConnectionString("ConnectionString");
            Console.WriteLine("������ ������ employee");
            // ���������� ������ ����������� ��� ��������� DbContext
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
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, User employee)
        {
            if (id != employee.user_id)
            {
                return BadRequest("The provided id does not match the user_id in the request body.");
            }

            _context.Entry(employee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
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
            // ����� ���������� ���� � Int32
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
