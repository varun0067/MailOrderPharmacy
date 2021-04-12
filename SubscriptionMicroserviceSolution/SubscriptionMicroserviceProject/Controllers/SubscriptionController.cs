using Microsoft.AspNetCore.Mvc;
using SubscriptionMicroserviceProject.Models;
using SubscriptionMicroserviceProject.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using SubscriptionMicroserviceProject.SubscriptionServices;
using SubscriptionMicroserviceProject.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SubscriptionMicroserviceProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class SubscriptionController : ControllerBase
    {
        ISubscriptionService _subscriptionService;
        public SubscriptionController(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }

        [HttpPost("createPrescription")]
        public ActionResult CreatePrescription([FromBody]MemberPrescription prescription)
        {
            bool added = _subscriptionService.CreatePrescription(prescription);
            if(added)
            {
                return Ok(prescription);
            }
            return BadRequest("Could not add Prescription");
        }

        [HttpPost("Subscribe")]
        public ActionResult Subscription([FromBody] SubscriptionDTO subscription)
        {
            string subscribeResult = _subscriptionService.Subscribe(subscription,subscription.Token);
            if (subscribeResult == "Subscription Create")
                return Ok(subscribeResult);
            else
                return BadRequest(subscribeResult);
        }

        [HttpPost("UnSubscribe/{subscriptionId}")]
        public ActionResult UnSubscription(int subscriptionId,[FromBody]string token)
        {
            string unSubscribeResult = _subscriptionService.UnSubscribe(subscriptionId,token);
            if (unSubscribeResult == "Unsubscribed")
                return Ok(unSubscribeResult);
            else
                return BadRequest(unSubscribeResult);
        }
        [HttpGet("getAllPrescriptions/{memberId}")]
        public ActionResult getAllPrescriptions(int memberId)
        {
            List < MemberPrescription > prescriptions= _subscriptionService.GetPrescriptions(memberId);
            if (prescriptions != null)
                return Ok(prescriptions);
            else
                return NoContent();

        }

        [HttpGet("getAllSubscriptions/{memberId}")]
        public ActionResult getAllSubscriptions(int memberId)
        {
            List<MemberSubscription> subscriptions = _subscriptionService.GetSubscriptions(memberId);
            if (subscriptions != null)
                return Ok(subscriptions);
            else
                return NoContent();

        }
        //[HttpPost("setToken")]
        //public ActionResult setToken([FromBody]string tokenUser)
        //{
        //    HttpContext.Session.SetString("JWTToken", tokenUser);

        //    return Ok();
        //}
        //[HttpGet("clearToken")]
        //public ActionResult clearToken()
        //{
        //    HttpContext.Session.Clear();

        //    return Ok();
        //}


        //[HttpPost("Unsubscription/{memberId}/{subscriptionId}")]
        //public async Task<ActionResult> Unsubscription(int memberId,int subscriptionId)
        //{
        //    try
        //    {
        //        string subscribeResult = _subscriptionService.Unsubscribe(memberId,subscriptionId);
        //        return Ok(subscribeResult);
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest(" Error " + e.Message);
        //    }
        //}

        ////Only for testing perpose
        //[HttpGet]
        //public List<MemberSubscription> Get()
        //{
        //    return _subscriptionService.GetData();
        //}
    }
}
