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
    public class AuthorizationController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Login(MemberLoginDTO member)
        {
            HttpClient client = new HttpClient();
            string uri = "http://localhost:7047/api/Authorization/Login";

            StringContent content = new StringContent(JsonConvert.SerializeObject(member), Encoding.UTF8, "application/json");
            var myResponse = await client.PostAsync(uri, content);

            if (myResponse.StatusCode == HttpStatusCode.OK)
            {
                TokenUserDTO tokenUser = myResponse.Content.ReadAsAsync<TokenUserDTO>().Result;
                HttpContext.Session.SetString("JWTToken", tokenUser.Token);
                HttpContext.Session.SetInt32("MemberId", tokenUser.MemberId);

                //HttpClient client1 = new HttpClient();
                //client1.BaseAddress = new Uri("http://localhost:53504");
                //var token = HttpContext.Session.GetString("JWTToken");
                //StringContent content1 = new StringContent(JsonConvert.SerializeObject(tokenUser.Token), Encoding.UTF8, "application/json");
                //client1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                //HttpResponseMessage response = client1.PostAsync("/api/Subscription/setToken", content1).Result;

                return RedirectToAction("Index","Member");
            }
            else
            {
                ViewBag.Message = "Invalid Credentials.";
                return View();
            }
            
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://localhost:53504");
            //var token = HttpContext.Session.GetString("JWTToken");
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            //HttpResponseMessage response = client.GetAsync("/api/Subscription/clearToken").Result;

            return RedirectToAction("Index", "Home");
        }
    }
}
