using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBugTracker.Models;

namespace TheBugTracker.Services.Interfaces
{
    public interface IBTCompanyInfoService
    {
        public Task<Company> GetCompanyInfoByIdAsync(int? companyId);
        public Task<List<BTUser>> GetAllMemberAsync(int companyId);
        public Task<List<Project>> GetAllProjectAsync(int companyId);
        public Task<List<Ticket>> GetAllTicketsAsync(int companyId);
        

    }
}
