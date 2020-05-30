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
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        private ApplicationDbContext _dbContext;
        public SubscriptionController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_dbContext.Subscriptions.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var subscriptionToFind = _dbContext.Subscriptions.Find(id);

            if (subscriptionToFind == null)
                return BadRequest("No Subscription Exists with Id: " + id);

            return Ok(subscriptionToFind);
        }


        [HttpPost]
        public IActionResult Create([FromBody] Subscription subscription)
        {
            subscription.DateCreated = DateTime.UtcNow;
            _dbContext.Subscriptions.Add(subscription);
            _dbContext.SaveChanges();

            return Ok(subscription);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Subscription updatedSubscription)
        {
            var subscriptionToUpdate = _dbContext.Subscriptions.Find(id);
            if (subscriptionToUpdate == null)
                return BadRequest("No Subscription Exists with Id: "+id);

            if (subscriptionToUpdate.Name != null || subscriptionToUpdate.Name != updatedSubscription.Name)
                subscriptionToUpdate.Name = updatedSubscription.Name;

            if (subscriptionToUpdate.Company != null || subscriptionToUpdate.Company != updatedSubscription.Company)
                subscriptionToUpdate.Company = updatedSubscription.Company;

            if (subscriptionToUpdate.Price != updatedSubscription.Price)
                subscriptionToUpdate.Price = updatedSubscription.Price;


            if (subscriptionToUpdate.RenewalDay != updatedSubscription.RenewalDay)
                subscriptionToUpdate.RenewalDay = updatedSubscription.RenewalDay;


            _dbContext.Subscriptions.Update(subscriptionToUpdate);
            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var subscriptionToDelete = _dbContext.Subscriptions.Find(id);

            if (subscriptionToDelete == null)
                return BadRequest("No Subscription Exists with Id: " + id);

            _dbContext.Subscriptions.Remove(subscriptionToDelete);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
