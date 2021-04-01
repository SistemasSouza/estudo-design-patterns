using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
          //var payment = new PayPal();
          
          var payment = new PayonnerAdapter(new Payonner());

          payment.PayPalPayment();
          payment.PayPalReceive();

           Console.ReadLine();
        }
    }
}
