using DrugServiceAPIProject.DrugServices;
using DrugServiceAPIProject.DTO;
using DrugServiceAPIProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DrugServiceAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DrugsController : ControllerBase
    {
        private IDrugService _drugService;
        public DrugsController(IDrugService drugService)
        {
            _drugService = drugService;
        }

        //[HttpGet("getAvailability/{id}/{location}/{qty}")]
        //public async Task<ActionResult> GetAvailability(int id, string location, int qty)
        //{
        //    var res = _drugService.GetAvailability(id, location, qty);
        //    return Ok(res);
        //}
        //method to get drugs details by drug id
        
        [HttpGet("SearchDrugById/{id}")]
        public ActionResult<Drug> Get(int id)
        {
            if (id == 0)
                return BadRequest("Please give valid id");

            var Drug= _drugService.GetDrugById(id);
            if (Drug == null)
                return BadRequest("data not found");
            else
                return Ok(Drug);
        }
        //method to get drugs details by drug name
        [HttpGet("searchDrugsByName/{name}")]
        public ActionResult<Drug> Get(string name)
        {
            if (name == null)
                return BadRequest("please give valid name");
            var result=_drugService.GetDrugByName(name);
            if (result == null)
                return BadRequest("data not found");
            else
                return result;
        }

        //method to get details of a drug from particular locations
        [HttpPost("getDispatchableDrugStock/{id}/{location}")]
        public ActionResult<DispatchableDrugStockDTO> Post(int id,string location)
        {
            if (id == 0 || location == null)
                return BadRequest("please give valid details");
            var result = _drugService.GetDispatchableDrugStock(id,location);
            if (result ==null)
                return BadRequest("data not found");
            else
                return Ok(result);
        }

        [HttpGet("getAllDrugs")]
        public ActionResult<Drug> GetALLDrugs()
        {
            List<DrugDetailsDTO> result = _drugService.GetAllDrugs();
            if (result != null)
                return Ok(result);
            else
                return NoContent();
        }
    }
}
