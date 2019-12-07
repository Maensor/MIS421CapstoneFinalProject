using System;
using System.Collections.Generic;
using System.Text;

namespace MIS421CapstoneFinalProject.Models.ViewModels
{
    public class CartViewModel
    {
        public IList<Service> ServiceList { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}
