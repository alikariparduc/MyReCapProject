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
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll(string ad,string password)
        {
          
            if (ad=="Ali") //Ad=Ali gönderilirse liste gelecek.Değilse Başarısız yazıp 404 dönecek.
            {
                var result = _customerService.GetAll();
                return Ok(result);
            }
            return Unauthorized("Başarısız");
            

        }

    }
}
