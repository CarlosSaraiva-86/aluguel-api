using Domain.Entities;
using Infrastructure.Context;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    public class LoginRepository : BaseRepository<Login>, ILoginRepository
    {
        public LoginRepository(ApplicationContext context) : base(context)
        {
        }

        public Login Get(string user, string password)
        {
            return dbSet
                .Where(x => x.user == user && x.password == password)
                .SingleOrDefault();
        }

        public bool Set(Login login)
        {
            dbSet.Add(login);
            context.SaveChanges();
            return true;
        }
    }
}
