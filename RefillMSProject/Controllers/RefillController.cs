using Microsoft.AspNetCore.Mvc;
using RefillMSProject.Models;
using RefillMSProject.RefillRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RefillMSProject.RefillService;
using RefillMSProject.DTO;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RefillMSProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RefillController : ControllerBase
    {
        private IRefillService _refillService;

        public RefillController(IRefillService refillService)
        {
            _refillService = refillService;
        }

        [HttpPost("CreateRefill")]
        public ActionResult CreateRefill([FromBody] RefillOrderDTO refillOrder)
        {
            bool created = _refillService.CreateRefillOrders(refillOrder);
            if (created)
                return Ok();
            else
                return BadRequest("Cannot Create Refill orders");
        }

        [HttpGet("viewRefillStatus/{subscriptionId}")]
        public ActionResult viewRefillStatus(int subscriptionId)
        {
            List<RefillOrder> refillStatus = _refillService.GetRefillOrders(subscriptionId);
            if (refillStatus == null)
            {
                return NoContent();
            }
            else
            {
                return Ok(refillStatus);
            }
        }
        [HttpGet("getRefillDuesAsOfDate/{subId}/{fromDate}")]
        public ActionResult getRefillDuesAsOfDate(int subId, DateTime fromDate)
        {
            List<RefillOrder> refillStatus = _refillService.GetRefillDuesAsOfDate(subId, fromDate);
            if (refillStatus == null)
            {
                return NoContent();
            }
            else
            {
                return Ok(refillStatus);
            }
        }
        [HttpPost("requestAdhocRefill/{subscriptionId}/{refillId}")]
        public ActionResult requestAdhocRefill(int subscriptionId,int refillId)
        {
            bool requested = _refillService.RequestAdhocRefill(subscriptionId, refillId);
            if (requested == true)
                return Ok();
            else
                return BadRequest("Could not complete Payment");
        }

        [HttpGet("checkPendingPaymentStatus/{subscriptionId}")]
        public ActionResult checkPendingPaymentStatus(int subscriptionId)
        {
            bool pendingStatus = _refillService.CheckPendingPaymentStatus(subscriptionId);
            if (pendingStatus == true)
                return Ok();
            else
                return BadRequest("Please Complete Payment for pending requests");
        }
            //// GET: api/<RefillController>
            //[HttpGet("getRefillStatus/{id}")]
            //public async Task<ActionResult> GetRefillStatus(int id)
            //{
            //    try
            //    {
            //        var res = _refillService.GetRefillStatus(id);

            //        if (res == 1)
            //            return Ok("Refill Completed");
            //        else if (res == 2)
            //            return Ok("Refill is Due");
            //        else
            //            return NotFound();

            //    }
            //    catch (Exception e)
            //    {
            //        return BadRequest(e.Message);
            //    }

            //}

            //[HttpGet("getRefillDuesAsOfDate/{id}")]
            //public async Task<ActionResult> GetRefillDuesAsOfDate(int id,[FromBody]string date)
            //{
            //    try
            //    {
            //        DateTime dt = Convert.ToDateTime(date);
            //        int dues = _refillService.GetRefillDuesAsOfDate(id, dt);
            //        return Ok(dues);
            //    }
            //    catch (Exception e)
            //    {
            //        return BadRequest(e.Message);
            //    }
            //}


            //[HttpPost("requestAdhocRefill/{id}/{location}")]
            //public async Task<ActionResult> RequestAdhocRefill(int id, string location)
            //{
            //    try
            //    {
            //        int refillId = _refillService.RequestAdhocRefill(id, location);
            //        if (refillId == 0)
            //            return BadRequest("Refill request Failed");
            //        else
            //            return Ok("Refill Request Accepted \nRefill ID : "+refillId);
            //    }
            //    catch (Exception e)
            //    {
            //        return BadRequest(e.Message);
            //    }
            //}



            //// PUT api/<RefillController>/5
            //[HttpPut("{id}")]
            //public void Put(int id, [FromBody] string value)
            //{
            //}

            //// DELETE api/<RefillController>/5
            //[HttpDelete("{id}")]
            //public void Delete(int id)
            //{
            //}
        }
}
