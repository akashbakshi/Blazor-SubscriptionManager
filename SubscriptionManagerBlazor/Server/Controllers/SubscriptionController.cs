using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SubscriptionManagerBlazor.Server.Data;
using SubscriptionManagerBlazor.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SubscriptionManagerBlazor.Server.Controllers
{
    [Route("api/sub")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        SubscriptionDataAccessLayer _dal;
        public SubscriptionController(SubscriptionDataAccessLayer dal)
        {
            _dal = dal;
        }
        // GET: api/<SubscriptionController>
        [HttpGet]
        public IEnumerable<Subscription> Get()
        {
            return _dal.Get();
        }

        // GET api/<SubscriptionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SubscriptionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SubscriptionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SubscriptionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
