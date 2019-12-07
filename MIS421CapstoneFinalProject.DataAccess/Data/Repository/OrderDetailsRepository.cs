using System;
using System.Collections.Generic;
using System.Text;
using MIS421CapstoneFinalProject.DataAccess.Data.Repository.IRepository;
using MIS421CapstoneFinalProject.Models;

namespace MIS421CapstoneFinalProject.DataAccess.Data.Repository
{
    public class OrderDetailsRepository : Repository<OrderDetails>, IOrderDetailsRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderDetailsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


    }
}
