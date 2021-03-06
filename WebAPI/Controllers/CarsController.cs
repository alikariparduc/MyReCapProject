using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
        public class CarsController : ControllerBase
        {
            ICarService _carService;

            public CarsController(ICarService carService)
            {
                _carService = carService;
            }

            [HttpGet]
            public IActionResult GetAll()
            {
                var result = _carService.GetAll();
                return Ok(result);
            }
        }
    
}
