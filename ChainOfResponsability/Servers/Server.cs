using System;

using System.Collections.Generic;
using ChainOfResponsability.Middlewares;

namespace ChainOfResponsability.Servers
{
    class Server
    {
        private Dictionary<string, string> _users = new Dictionary<string, string>();

        private Middleware _middleware;

        public void SetMiddleware(Middleware middleware)
        {
            _middleware = middleware;
        }

        public bool LogIn(string username, string password)
        {
            if (_middleware.Check(username, password))
            {
                Console.WriteLine("Usuário autorizado com sucesso");
                Console.WriteLine("Seja Bem-vindo");
                return true;
            }

            return false;
        }

        public void RegisterUser(string username, string password)
        {
            _users[username] = password;
        }

        public bool HasEmail(string username)
        {
            return _users.ContainsKey(username);
        }

        public bool IsValidPassword(string username, string password)
        {
            _users.TryGetValue(username, out string value);

            return password == value;
        }
    }
}