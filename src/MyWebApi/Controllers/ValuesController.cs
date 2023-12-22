using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MyWebApi.Models;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Value>> Get()
        {
            // Simulate log statement
            System.Diagnostics.Debug.WriteLine("Getting values...");

            var values = new Value[] { new Value { Id = 1, Text = "Value1" }, new Value { Id = 2, Text = "Value2" } };

            // Simulate log statement
            System.Diagnostics.Debug.WriteLine("Values retrieved successfully.");

            return values;
        }
    }
}
