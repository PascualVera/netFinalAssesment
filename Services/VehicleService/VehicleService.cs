using finalAssesmentLaBestia.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using finalAssesmentLaBestia.Models;

namespace finalAssesmentLaBestia.Services.VehicleService
{
    public class VehicleService : IVehicleService
    {
        private readonly DataContext context;
        public VehicleService(DataContext context)
        {
            this.context = context;
        }

        public async Task<ServiceResponse<Vehicle>> addVehicle(Vehicle vehicle)
        {
            try
            {
                context.Add(vehicle);
                await context.SaveChangesAsync();
                return new ServiceResponse<Vehicle>(true, vehicle);
            }
            catch (Exception ex)
            {
                return new ServiceResponse<Vehicle>(false, null);
            }
        }

        public async Task<ServiceResponse<Vehicle>> editVehicle(Vehicle updatedVehicle)
        {
            try
            {
                Vehicle vehicle = await context.Vehicles.FirstAsync(vehicle => vehicle.id == updatedVehicle.id);

                vehicle.name = updatedVehicle.name;
                vehicle.owner_id = updatedVehicle.owner_id == default(int) ? vehicle.owner_id : updatedVehicle.owner_id;
                await context.SaveChangesAsync();

                return new ServiceResponse<Vehicle>(true, vehicle);
            }
            catch (Exception ex)
            {
                return new ServiceResponse<Vehicle>(false, null);
            }
        }

        public async Task<ServiceResponse<List<Vehicle>>> getAllVehicles()
        {
            try 
            { 
                List<Vehicle> vehicles = await context.Vehicles.ToListAsync();
                return new ServiceResponse<List<Vehicle>>(true, vehicles);
            }
            catch (Exception ex)
            {
                return new ServiceResponse<List<Vehicle>>(false, null);
            }
        }

        public async Task<ServiceResponse<Vehicle>> getVehicle(int id)
        {
            try
            {
                Vehicle v = await context.Vehicles.FirstAsync(vehicle => vehicle.id == id);
                return new ServiceResponse<Vehicle>(true, v);
            }
            catch (Exception ex)
            {
                return new ServiceResponse<Vehicle>(false, null);
            }
        }

        public async Task<ServiceResponse<List<Vehicle>>> getVehicleByOwnerId(int owner_id)
        {
            try
            {
                List<Vehicle> vehicles = await context.Vehicles.Where(vehicle => vehicle.owner_id == owner_id).ToListAsync();
                return new ServiceResponse<List<Vehicle>>(true, vehicles);
            }
            catch(Exception ex)
            {
                return new ServiceResponse<List<Vehicle>>(false, null);
            }
        }
    }
}
