using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailOrderMVCConsume.DTO
{
    public class SubscriptionDetailsDTO
    {
        public int SubscriptionId { get; set; }
        public int MemberId { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public int PrescriptionId { get; set; }
        public Occurrence RefillOccurrence { get; set; }
        public string MemberLocation { get; set; }
        public bool SubscriptionStatus { get; set; }
    }
}
