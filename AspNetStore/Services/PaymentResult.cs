using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetStore.Services
{
    public class PaymentResult
    { 
        public string TransactionId { get; set; } 
        public bool Succeeded { get; set; } 
        public string Message { get; set; }
    }
}