using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
          //var payment = new PayPal();
          
          var payment = new MercadoPagoAdapter(new MercadoPago());

          payment.PayPalPayment();
          payment.PayPalReceive();

           Console.ReadLine();
        }
    }
}
