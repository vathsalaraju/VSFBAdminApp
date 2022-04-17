using Microsoft.AspNetCore.Mvc;
using VSFBAdminApp.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VSFBAdminApp.NewFolder
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAccountsController : ControllerBase
    {
        private readonly ICustomerAccounts _db;
        public CustomerAccountsController(ICustomerAccounts customeraccRepo)
        {
            _db = customeraccRepo;

        }

        // GET: api/<CustomerAccountsController>
        [HttpGet]
        public IActionResult GetCustomerAccounts()
        {
            return Ok(_db.GetCustomerAccs());
        }

        // GET api/<CustomerAccountsController>/5
        [HttpGet("{id}")]
        public IActionResult GetCustomerAccountsById(string id)
        {
            return Ok(_db.GetCustomerAccsById(id));
        }

       
        }

        
    }

