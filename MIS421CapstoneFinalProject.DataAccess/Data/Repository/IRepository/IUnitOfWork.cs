using System;
using System.Collections.Generic;
using System.Text;
using MIS421CapstoneFinalProject.DataAccess.Data.Repository.IRepository;

namespace MIS421CapstoneFinalProject.DataAccess.Data.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        IFrequencyRepository Frequency { get; }
        IServiceRepository Service { get; }

        void Save();
    }
}
