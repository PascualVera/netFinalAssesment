using finalAssesmentLaBestia.Models;

namespace finalAssesmentLaBestia.Services.ClaimService
{
    public interface IClaimService
    {
        public Task<ServiceResponse<List<Claim>>> getAllClaims();
        public Task<ServiceResponse<Claim>> getClaim(int id);
        public Task<ServiceResponse<List<Claim>>> getClaimByVehicleId(int vehicleId);
        public Task<ServiceResponse<Claim>> addClaim(Claim Claim);
        public Task<ServiceResponse<Claim>> editClaim(Claim updatedClaim);

    }
}
