using System;
using System.Collections.Generic;
using System.Text;
using MIS421CapstoneFinalProject.Models;

namespace MIS421CapstoneFinalProject.DataAccess.Data.Repository.IRepository
{
    public interface IUserRepository : IRepository<ApplicationUser>
    {
        void LockUser(string userId);

        void UnLockUser(string userId);
    }
}
