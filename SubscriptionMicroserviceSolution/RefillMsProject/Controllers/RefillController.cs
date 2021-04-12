using Microsoft.AspNetCore.Mvc;
using RefillMsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RefillMsProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefillController : ControllerBase
    {
        [HttpPost("{id}")]
        public ActionResult getRefillStatus(int id)
        {
            RefillOrderDTO refillOrderDTO = new RefillOrderDTO();

            if(id==1)
            {
                return Ok("Refill Completed");
            }
            else if(id==2)
            {
                return Ok("Refill is Due");
            }
            else
                return NotFound();
        }

    }
}
