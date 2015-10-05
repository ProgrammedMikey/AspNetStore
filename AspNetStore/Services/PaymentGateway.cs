using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetStore.Services
{
    public class PaymentGateway : IGateway
    { 
        public PaymentResult ProcessPayment(ViewModels.CheckoutViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}