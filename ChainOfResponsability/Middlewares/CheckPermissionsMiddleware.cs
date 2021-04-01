using System;

namespace ChainOfResponsability.Middlewares
{
    class CheckPermissionsMiddleware : Middleware
    {
        public override bool Check(string username, string password)
        {
            if (username.Equals("denyssouza1@hotmail.com"))
            {
                Console.WriteLine("Seja bem-vindo administrador");
                return true;
            }

            Console.WriteLine("Seja bem-vindo");

            return CheckNext(username, password);
        }
    }
}