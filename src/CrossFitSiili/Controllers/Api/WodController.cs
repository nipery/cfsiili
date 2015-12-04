using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrossFitSiili.Models;
using CrossFitSiili.Repository;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;

namespace CrossFitSiili.Controllers.Api
{
    [Route("api/wods")]
    public class WodController : Controller
    {
        private readonly IWodRepository _wodRepository;
        

        public WodController(IWodRepository wodRepository)
        {
            _wodRepository = wodRepository;
        }

        [HttpGet("")]
        public async Task<JsonResult> Get()
        {
            try
            {
                var wods = await _wodRepository.GetWods();
                return Json(wods);
            }
            catch (Exception ex)
            {
                return Json(ex.ToString());   
            }
            
        }

        [HttpPost("")]
        public async Task<JsonResult> Post([FromBody] Wod wod)
        {

           await _wodRepository.AddWod(wod);
           

            return Json(true);
        }
    }
}