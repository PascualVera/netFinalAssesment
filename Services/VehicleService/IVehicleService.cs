using finalAssesmentLaBestia.Models;

namespace finalAssesmentLaBestia.Services.VehicleService
{
    public interface IVehicleService
    {
        public Task<ServiceResponse<List<Vehicle>>> getAllVehicles();
        public Task<ServiceResponse<Vehicle>> getVehicle(int id);
        public Task<ServiceResponse<List<Vehicle>>> getVehicleByOwnerId(int ownerId);
        public Task<ServiceResponse<Vehicle>> addVehicle(Vehicle vehicle);
        public Task<ServiceResponse<Vehicle>> editVehicle(Vehicle updatedVehicle);

    }
}
