using finalAssesmentLaBestia.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace finalAssesmentLaBestia.Services.OwnerService
{
    public class OwnerService : IOwnerService
    {
        private readonly DataContext context;
        public OwnerService(DataContext context)
        {
            this.context = context;
        }
        public async Task<ServiceResponse<Owner>> addOwner(Owner owner)
        {
            context.Add(owner);
            await context.SaveChangesAsync();
            ServiceResponse<Owner> serviceResponse = new ServiceResponse<Owner>(true, owner);
            return serviceResponse;
        }

        public async Task<ServiceResponse<Owner>> editOwner(Owner updateOwner)
        {

            Owner owner = await context.Owners.FirstOrDefaultAsync(owner => owner.id == updateOwner.id);

            owner.name = updateOwner.name;
            await context.SaveChangesAsync();

            ServiceResponse<Owner> serviceResponse = new ServiceResponse<Owner>(true, owner);
            return serviceResponse;

        }

        public async Task<ServiceResponse<List<Owner>>> getAllOwners()
        {
            List<Owner> dbOwners = await context.Owners.ToListAsync();

            ServiceResponse<List<Owner>> serviceResponse = new ServiceResponse<List<Owner>>(true, dbOwners);
            return  serviceResponse;
        }

        public async Task<ServiceResponse<Owner>> getOwner(int id)
        {
            Owner owner = await context.Owners.FirstOrDefaultAsync(owner=>owner.id == id);

            ServiceResponse<Owner> serviceResponse = new ServiceResponse<Owner>(true, owner);
            return serviceResponse;
        }
    }
}
