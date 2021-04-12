using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefillMsProject.Models
{
    public class RefillOrderDTO
    {
        public int SubscriptionID { get; set; }
        public int RefillOrderID { get; set; }
        public DateTime RefillDate { get; set; }
        public bool Status { get; set; }
        public int DrugID { get; set; }
        public int Quantity { get; set; }
    }
}
