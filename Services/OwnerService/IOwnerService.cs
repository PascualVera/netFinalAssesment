using finalAssesmentLaBestia.Models;
using System.Threading.Tasks;
namespace finalAssesmentLaBestia.Services.OwnerService
{
    public interface IOwnerService
    {
        public Task<ServiceResponse<List<Owner>>> getAllOwners();
        public Task<ServiceResponse<Owner>> getOwner(int id);
        public Task<ServiceResponse<Owner>> addOwner(Owner owner);
        public Task<ServiceResponse<Owner>> editOwner(Owner owner);

    }
}
