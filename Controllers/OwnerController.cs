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
        public async Task<ServiceResponse<List<Owner>>> getUsers()
        {
            return await service.getAllOwners();
        }

        [HttpPost]
        [Route("/add")]

        public async Task<ServiceResponse<Owner>> addOwner(Owner owner)
        {
            return await service.addOwner(owner);
        }

        [HttpPut]
        [Route("/edit")]

        public async Task<ServiceResponse<Owner>> editOwner(Owner owner)
        {
            return await service.editOwner(owner);
        }
        [HttpGet]
        [Route("/owner")]

        public async Task<ServiceResponse<Owner>> findOwner(int id)
        {
            return await service.getOwner(id);
        }
    }
}
