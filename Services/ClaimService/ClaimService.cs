using finalAssesmentLaBestia.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using finalAssesmentLaBestia.Models;

namespace finalAssesmentLaBestia.Services.ClaimService
{
    public class ClaimService : IClaimService
    {
        private readonly DataContext context;
        public ClaimService(DataContext context)
        {
            this.context = context;
        }

        public async Task<ServiceResponse<Claim>> addClaim(Claim Claim)
        {
            try
            {
                context.Add(Claim);
                await context.SaveChangesAsync();
                return new ServiceResponse<Claim>(true, Claim);
            }
            catch (Exception ex)
            {
                return new ServiceResponse<Claim>(false, null);
            }
        }

        public async Task<ServiceResponse<Claim>> editClaim(Claim updatedClaim)
        {
            try
            {
                Claim Claim = await context.Claims.FirstAsync(Claim => Claim.id == updatedClaim.id);

                Claim.Description = updatedClaim.Description;
                Claim.Status = updatedClaim.Status;
                Claim.Date = updatedClaim.Date;
                Claim.Vehicle_id = updatedClaim.Vehicle_id == default(int) ? Claim.Vehicle_id : updatedClaim.Vehicle_id;
                
                await context.SaveChangesAsync();

                return new ServiceResponse<Claim>(true, Claim);
            }
            catch (Exception ex)
            {
                return new ServiceResponse<Claim>(false, null);
            }
        }

        public async Task<ServiceResponse<List<Claim>>> getAllClaims()
        {
            try 
            { 
                List<Claim> Claims = await context.Claims.ToListAsync();
                return new ServiceResponse<List<Claim>>(true, Claims);
            }
            catch (Exception ex)
            {
                return new ServiceResponse<List<Claim>>(false, null);
            }
        }

        public async Task<ServiceResponse<Claim>> getClaim(int id)
        {
            try
            {
                Claim v = await context.Claims.FirstAsync(Claim => Claim.id == id);
                return new ServiceResponse<Claim>(true, v);
            }
            catch (Exception ex)
            {
                return new ServiceResponse<Claim>(false, null);
            }
        }

        public async Task<ServiceResponse<List<Claim>>> getClaimByVehicleId(int vehicleid)
        {
            try
            {
                List<Claim> Claims = await context.Claims.Where(Claim => Claim.Vehicle_id == vehicleid).ToListAsync();
                return new ServiceResponse<List<Claim>>(true, Claims);
            }
            catch(Exception ex)
            {
                return new ServiceResponse<List<Claim>>(false, null);
            }
        }
    }
}
