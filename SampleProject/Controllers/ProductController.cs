using DomainModels.Product.Vehicle;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DomainTest.Controller
{
    //TODO Service Injection

    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
       
        private readonly ILogger<Vehicle> _logger;

        public ProductController(ILogger<Vehicle> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Vehicle> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Vehicle
            {
               //initializate object
            })
            .ToArray();
        }
    }
}
