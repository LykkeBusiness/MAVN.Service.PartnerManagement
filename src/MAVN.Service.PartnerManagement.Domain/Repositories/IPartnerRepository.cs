using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MAVN.Service.PartnerManagement.Domain.Models;

namespace MAVN.Service.PartnerManagement.Domain.Repositories
{
    public interface IPartnerRepository
    {
        Task<Partner> CreateAsync(Partner partner);
        Task UpdateAsync(Partner partner);
        Task DeleteAsync(Guid partnerId);
        Task<(IReadOnlyCollection<Partner> partners, int totalSize)> GetAsync(int page, int pageSize, string name, Vertical? vertical);
        Task<Partner> GetByIdAsync(Guid partnerId);
        Task<Partner> GetByClientIdAsync(string clientId);
        Task<Partner> GetByLocationIdAsync(Guid locationId);

        Task<IReadOnlyCollection<Partner>> GetByIdsAsync(IEnumerable<Guid> ids);
    }
}
