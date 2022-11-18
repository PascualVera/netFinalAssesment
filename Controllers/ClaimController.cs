using finalAssesmentLaBestia.Models;
using finalAssesmentLaBestia.Services.ClaimService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace finalAssesmentLaBestia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : ControllerBase
    {
        private IClaimService service
        { get; set; }

        public ClaimController(IClaimService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("/claim/all")]
        public async Task<ActionResult<ServiceResponse<List<Claim>>>> getUsers()
        {
            ServiceResponse<List<Claim>> res = await service.getAllClaims();
            if (res.Ok)
            {
               return Ok(res);
            }
            else
            {
                return BadRequest(res);
            }
            
        }

        [HttpPost]
        [Route("/claim/add")]
        public async Task<ActionResult<ServiceResponse<Claim>>> addClaim(Claim Claim)
        {
            ServiceResponse<Claim> res = await service.addClaim(Claim);
            if (res.Ok)
            {
                return Accepted(res);
            }
            else
            {
                return BadRequest(res);
            }
            
        }

        [HttpPut]
        [Route("/claim/edit")]
        public async Task<ActionResult<ServiceResponse<Claim>>> editClaim(Claim Claim)
        {
            ServiceResponse<Claim> res = await service.editClaim(Claim);
            if (res.Ok)
            {
                return Accepted(res);
            }
            else
            {
                return BadRequest(res);
            }
         
        }

        [HttpGet]
        [Route("/claim/id")]
        public async Task<ActionResult<ServiceResponse<Claim>>> findClaim(int id)
        {
            ServiceResponse<Claim> res = await service.getClaim(id);
            if (res.Ok)
            {
                return Accepted(res);
            }
            else
            {
                return BadRequest(res);
            }
        }

        [HttpGet]
        [Route("/claim/vehicle/id")]
        public async Task<ActionResult<ServiceResponse<List<Claim>>>> findClaimByVehicleId(int id)
        {
            ServiceResponse<List<Claim>> res = await service.getClaimByVehicleId(id);
            if (res.Ok)
            {
                return Accepted(res);
            }
            else
            {
                return BadRequest(res);
            }
        }
    }
}
