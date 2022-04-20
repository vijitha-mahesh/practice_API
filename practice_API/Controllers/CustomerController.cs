using Microsoft.AspNetCore.Mvc;
using practice_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace practice_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        List<CustomerModel> customers = new List<CustomerModel>
        {
            new CustomerModel{id ="123",firstName = "vijitha", lastName="mahesh", address="123/2,kurunegala, sri lanka"},
             new CustomerModel{id ="234",firstName = "tharindu", lastName="kumarasinghe", address="123/2,gall, sri lanka"},
             new CustomerModel{id ="345",firstName = "imasha", lastName="sithmini", address="123/2,gampaha, sri lanka"},
             new CustomerModel{id ="456",firstName = "pasidu", lastName="osanda", address="123/2,kaluthara, sri lanka"}
        };

        [HttpGet]
        public List<CustomerModel> Get()
        {
            return customers;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] CustomerModel customerModel)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
