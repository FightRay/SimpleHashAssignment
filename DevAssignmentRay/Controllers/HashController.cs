using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevAssignmentRay.Controllers
{
    /*
     * @author Ray
     * Created for the SpringboardVR assignment
     */
    [ApiController]
    [Route("[controller]")]
    public class HashController : ControllerBase
    {
        private readonly ILogger<HashController> _logger;

        public HashController(ILogger<HashController> logger)
        {
            _logger = logger;
        }

        /*
         * POST Endpoint (/hash)
         * Accepts an input string if not empty and returns the hashed output
        */
        [HttpPost]
        public ObjectResult Post(string input)
        {
            var result = new { status = false, output = "Input string cannot be empty!" };

            // If a proper string is received, hash it and store in the result object
            if (input != null && input.Length > 0)
            {
                result = new { status = true, output = Hasher.Hash(input) };
            }

            // Send a response with the result
            return Ok(result);
        }
    }
}
