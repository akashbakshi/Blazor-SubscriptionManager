using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SubscriptionManagerBlazor.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SubscriptionManagerBlazor.Server.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionDataAccessLayer
    {
        private ApplicationDbContext _dbContext;
        public SubscriptionDataAccessLayer(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: api/<SubscriptionDataAccessLayer>
        [HttpGet]
        public IEnumerable<Subscription> Get()
        {
            return _dbContext.Subscriptions.ToList();
        }

        // GET api/<SubscriptionDataAccessLayer>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SubscriptionDataAccessLayer>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SubscriptionDataAccessLayer>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SubscriptionDataAccessLayer>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
