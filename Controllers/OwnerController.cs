using finalAssesmentLaBestia.Models;
using finalAssesmentLaBestia.Services.OwnerService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace finalAssesmentLaBestia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private IOwnerService service
        { get; set; }

        public OwnerController(IOwnerService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("/owner/all")]
        public async Task<ActionResult<ServiceResponse<List<Owner>>>> getUsers()
        {
            ServiceResponse<List<Owner>> res = await service.getAllOwners();
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
        [Route("/owner/add")]

        public async Task<ActionResult<ServiceResponse<Owner>>> addOwner(Owner owner)
        {
            ServiceResponse<Owner> res = await service.addOwner(owner);
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
        [Route("/owner/edit")]

        public async Task<ActionResult<ServiceResponse<Owner>>> editOwner(Owner owner)
        {
            ServiceResponse<Owner> res = await service.editOwner(owner);
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
        [Route("/owner/id")]

        public async Task<ActionResult<ServiceResponse<Owner>>> findOwner(int id)
        {
            ServiceResponse<Owner> res = await service.getOwner(id);
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
