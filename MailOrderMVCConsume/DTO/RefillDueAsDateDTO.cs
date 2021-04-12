using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailOrderMVCConsume.DTO
{
    public class RefillDueAsDateDTO
    {
        public int SubscriptionId { get; set; }
        public DateTime FromDate { get; set; }

    }
}
