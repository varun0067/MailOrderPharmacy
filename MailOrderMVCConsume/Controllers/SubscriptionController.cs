using MailOrderMVCConsume.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MailOrderMVCConsume.Controllers
{
    public class SubscriptionController : Controller
    {
        public IActionResult CreatePrescription()
        {
            int MemberId = (int)HttpContext.Session.GetInt32("MemberId");
            ViewBag.Id = MemberId;
            return View();
        }
        [HttpPost]
        public IActionResult CreatePrescription(MemberPrescriptionDTO prescription)
        {
            prescription.MemberId= (int)HttpContext.Session.GetInt32("MemberId");
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53504");
            var token = HttpContext.Session.GetString("JWTToken");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            StringContent content = new StringContent(JsonConvert.SerializeObject(prescription), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync("/api/Subscription/createPrescription", content).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                int MemberId = (int)HttpContext.Session.GetInt32("MemberId");
                ViewBag.Id = MemberId;
                ViewBag.Message = "Prescription Added";
                return View();
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
                return Unauthorized();
            else
            {
                ViewBag.Message = "Could not add prescription due to drug not found";
                return View();
            }
        }
        public IActionResult CreateSubscription(int prescriptionId)
        {
            int MemberId = (int)HttpContext.Session.GetInt32("MemberId");
            ViewBag.Id = MemberId;
            ViewBag.PrescriptionId = prescriptionId;
            return View();
        }
        [HttpPost]
        public IActionResult CreateSubscription(SubscriptionDTO subscription)
        {
            subscription.MemberId = (int)HttpContext.Session.GetInt32("MemberId");
            subscription.Token = HttpContext.Session.GetString("JWTToken");
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53504");
            var token = HttpContext.Session.GetString("JWTToken");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            StringContent content = new StringContent(JsonConvert.SerializeObject(subscription), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync("/api/Subscription/Subscribe", content).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                int MemberId = (int)HttpContext.Session.GetInt32("MemberId");
                ViewBag.Id = MemberId;
                string message = response.Content.ReadAsStringAsync().Result;
                ViewBag.Message = message;
                return View();
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
                return Unauthorized();
            else
            {
                string message = response.Content.ReadAsStringAsync().Result;
                ViewBag.Message = message;
                return View();
            }
        }

        public IActionResult UnSubscription(int SubscriptionId)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53504");
            var token = HttpContext.Session.GetString("JWTToken");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            StringContent content = new StringContent(JsonConvert.SerializeObject(token), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync("/api/Subscription/UnSubscribe/"+SubscriptionId,content).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                ViewBag.Message = response.Content.ReadAsStringAsync().Result;
                //return RedirectToAction("GetAllSubscriptions");
                return View();
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
                return Unauthorized();
            else
            {
                ViewBag.Message = response.Content.ReadAsStringAsync().Result;
                //return RedirectToAction("GetAllSubscriptions");
                return View();
            }
        }

        public IActionResult GetAllPrescriptions()
        {
            int MemberId = (int)HttpContext.Session.GetInt32("MemberId");
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53504");
            var token = HttpContext.Session.GetString("JWTToken");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage response = client.GetAsync("/api/Subscription/getAllPrescriptions/"+MemberId).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                List<PrescriptionDetailsDTO> prescriptions = response.Content.ReadAsAsync<List<PrescriptionDetailsDTO>>().Result;
                return View(prescriptions);
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
                return Unauthorized();
            else
                return NoContent();
        }
        public IActionResult GetAllSubscriptions()
        {
            int MemberId = (int)HttpContext.Session.GetInt32("MemberId");
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53504");
            var token = HttpContext.Session.GetString("JWTToken");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage response = client.GetAsync("/api/Subscription/getAllSubscriptions/"+MemberId).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                List<SubscriptionDetailsDTO> subscriptions = response.Content.ReadAsAsync<List<SubscriptionDetailsDTO>>().Result;
                return View(subscriptions);
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
                return Unauthorized();
            else
                return NoContent();
        }

    }
}
