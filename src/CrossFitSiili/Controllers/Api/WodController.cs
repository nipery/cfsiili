using System;
using System.Net;
using System.Threading.Tasks;
using CrossFitSiili.Repository;
using CrossFitSiili.ViewModels;
using Microsoft.AspNet.Mvc;

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
        public async Task<JsonResult> Post([FromBody]WodViewModel wodViewModel)
        {
            if (ModelState.IsValid)
            {
                Response.StatusCode = (int)HttpStatusCode.Created;
                return await Task.FromResult(Json(true));
                //  await _wodRepository.AddWod(wod);
            }
            Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return Json(new {Message = "Failed", ModelState = ModelState});
        }
    }
}