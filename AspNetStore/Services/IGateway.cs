using AspNetStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetStore.Services
{
    public interface IGateway
    {
        PaymentResult ProcessPayment(CheckoutViewModel model);
    }
}