using finalAssesmentLaBestia.Models;
using finalAssesmentLaBestia.Services.VehicleService;
using finalAssesmentLaBestia.Services.VehicleService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace finalAssesmentLaBestia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private IVehicleService service
        { get; set; }

        public VehicleController(IVehicleService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("/vehicle/all")]
        public async Task<ActionResult<ServiceResponse<List<Vehicle>>>> getUsers()
        {
            ServiceResponse<List<Vehicle>> res = await service.getAllVehicles();
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
        [Route("/vehicle/add")]
        public async Task<ActionResult<ServiceResponse<Vehicle>>> addVehicle(Vehicle Vehicle)
        {
            ServiceResponse<Vehicle> res = await service.addVehicle(Vehicle);
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
        [Route("/vehicle/edit")]
        public async Task<ActionResult<ServiceResponse<Vehicle>>> editVehicle(Vehicle Vehicle)
        {
            ServiceResponse<Vehicle> res = await service.editVehicle(Vehicle);
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
        [Route("/vehicle/id")]
        public async Task<ActionResult<ServiceResponse<Vehicle>>> findVehicle(int id)
        {
            ServiceResponse<Vehicle> res = await service.getVehicle(id);
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
        [Route("/vehicle/owner/id")]
        public async Task<ActionResult<ServiceResponse<List<Vehicle>>>> findVehicleByOwnerId(int id)
        {
            ServiceResponse<List<Vehicle>> res = await service.getVehicleByOwnerId(id);
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
