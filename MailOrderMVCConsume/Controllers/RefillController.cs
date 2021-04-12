using MailOrderMVCConsume.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MailOrderMVCConsume.Controllers
{
    public class RefillController : Controller
    {
        public IActionResult RefillStatus(int SubscriptionId)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:2393");
            var token = HttpContext.Session.GetString("JWTToken");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage response = client.GetAsync("/api/Refill/viewRefillStatus/" + SubscriptionId).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                List<RefillOrderDTO> refills = response.Content.ReadAsAsync<List<RefillOrderDTO>>().Result;
                return View(refills);
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
                return Unauthorized();
            else 
                return NoContent();
        }
        public IActionResult ConfirmRefill(int RefillId, int SubscriptionId)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:2393");
            var token = HttpContext.Session.GetString("JWTToken");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            StringContent content = new StringContent(JsonConvert.SerializeObject(""), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync("/api/Refill/requestAdhocRefill/" + SubscriptionId + "/" + RefillId, content).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                ViewBag.Message = "Payment Confirmed. Refill Completed will Reach in within 3 hours";
                return RedirectToAction("GetAllSubscriptions","Subscription");
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
                return Unauthorized();
            else
                return NoContent();
        }

        public IActionResult GetRefillDuesAsOfDate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetRefillDuesAsOfDate(RefillDueAsDateDTO refillDue)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:2393");
            var token = HttpContext.Session.GetString("JWTToken");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            DateTime dt = refillDue.FromDate;
            
            HttpResponseMessage response = client.GetAsync("/api/Refill/getRefillDuesAsOfDate/"+refillDue.SubscriptionId+"/"+ dt.ToString("yyyy-MM-dd")).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                List<RefillOrderDTO> refills = response.Content.ReadAsAsync<List<RefillOrderDTO>>().Result;
                return View("RefillDueAsDate", refills);
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
                return Unauthorized();
            else
                return NoContent();
        }

        public IActionResult RefillDueAsDate(List<RefillOrderDTO> refills)
        {
            return View(refills);
        }
    }
}
