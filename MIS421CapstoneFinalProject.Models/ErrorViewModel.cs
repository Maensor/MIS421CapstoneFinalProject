using System;

namespace MIS421CapstoneFinalProject.Models
{
    public class ErrorViewModel
    {
                public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
