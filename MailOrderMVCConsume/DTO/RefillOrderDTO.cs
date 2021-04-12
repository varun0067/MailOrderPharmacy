﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailOrderMVCConsume.DTO
{
    public enum RefilStatus
    {
        Pending,
        Completed
    }
    public class RefillOrderDTO
    {
        public int RefillOrderID { get; set; }
        public int SubscriptionID { get; set; }
        public DateTime RefillDate { get; set; }
        public int Quantity { get; set; }
        public string Location { get; set; }
        public double Price { get; set; }
        public RefilStatus Status { get; set; }
    }
}
