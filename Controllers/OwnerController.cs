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
        [Route("/all")]
        public async Task<ActionResult<ServiceResponse<List<Owner>>>> getUsers()
        {
            return  Ok(await service.getAllOwners());
        }

        [HttpPost]
        [Route("/add")]

        public async Task<ActionResult<ServiceResponse<Owner>>> addOwner(Owner owner)
        {
            return Accepted(await service.addOwner(owner));
        }

        [HttpPut]
        [Route("/edit")]

        public async Task<ActionResult<ServiceResponse<Owner>>> editOwner(Owner owner)
        {
            return Ok(await service.editOwner(owner));
        }
        [HttpGet]
        [Route("/owner")]

        public async Task<ActionResult<ServiceResponse<Owner>>> findOwner(int id)
        {
            return Ok(await service.getOwner(id));
        }
    }
}
