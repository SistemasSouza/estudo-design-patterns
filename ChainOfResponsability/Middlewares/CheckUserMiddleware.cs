using System;
using ChainOfResponsability.Servers;

namespace ChainOfResponsability.Middlewares
{
    class CheckUserMiddleware : Middleware
    {
        private Server _server;

        public CheckUserMiddleware(Server server)
        {
            _server = server;
        }

        public override bool Check(string username, string password)
        {
            if (!_server.HasEmail(username))
            {
                Console.WriteLine("E-mail inválido");
                return false;
            }

            if (!_server.IsValidPassword(username, password))
            {
                Console.WriteLine("E-mail e/ou senha inválidos");
                return false;
            }

            return CheckNext(username, password);
        }
    }
}