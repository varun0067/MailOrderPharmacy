using MailOrderMVCConsume.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MailOrderMVCConsume.Controllers
{
    public class DrugController : Controller
    {
        public IActionResult AllDrugs()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60177");
            var token = HttpContext.Session.GetString("JWTToken");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage response = client.GetAsync("/api/Drugs/getAllDrugs").Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                List<DrugDetailsDTO> drugs = response.Content.ReadAsAsync<List<DrugDetailsDTO>>().Result;
                return View(drugs);
            }
            else
                return Unauthorized();
        }
    }
}
