using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Controllers
{
    [Route("company/[controller]/[action]")]
    public class EmployeeController : Controller
    {
        public ContentResult Name()
        {
            return Content("Khoa");
        }
        public string Country()
        {
            return "Vietnam";
        }
        public string Index()
        {
            return "Hello from Employee";
        }
    }
}
