using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Interfaces
{
    public interface ILoginRepository
    {
        Login Get(string user, string password);
        bool Set(Login login);
    }
}
