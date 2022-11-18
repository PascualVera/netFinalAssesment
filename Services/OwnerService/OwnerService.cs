using finalAssesmentLaBestia.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using finalAssesmentLaBestia.Models;

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
            try
            {
                context.Add(owner);
                await context.SaveChangesAsync();
                return new ServiceResponse<Owner>(true, owner);
            }
            catch (Exception ex)
            {
                return new ServiceResponse<Owner>(false, null);
            }

        }

        public async Task<ServiceResponse<Owner>> editOwner(Owner updateOwner)
        {

            try
            {
                Owner owner = await context.Owners.FirstAsync(owner => owner.id == updateOwner.id);

                owner.FirstName = updateOwner.FirstName;
                owner.LastName = updateOwner.LastName;
                owner.DriverLicense = updateOwner.DriverLicense;
                await context.SaveChangesAsync();

                return new ServiceResponse<Owner>(true, owner);
            }
            catch (Exception ex)
            {
                return new ServiceResponse<Owner>(false, null);
            }

        }

        public async Task<ServiceResponse<List<Owner>>> getAllOwners()
        {
            try
            {
                List<Owner> dbOwners = await context.Owners.ToListAsync();

                return new ServiceResponse<List<Owner>>(true, dbOwners);
            }
            catch (Exception ex)
            {
                return new ServiceResponse<List<Owner>>(true, null);
            }
        }

        public async Task<ServiceResponse<Owner>> getOwner(int id)
        {

            try
            {
                Owner owner = await context.Owners.FirstAsync(owner => owner.id == id);

                return new ServiceResponse<Owner>(true, owner);


            }
            catch (Exception ex)
            {
                return new ServiceResponse<Owner>(false, null);
            }
        }
    }
}
