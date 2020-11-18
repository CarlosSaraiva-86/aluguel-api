using Domain.Entities;
using Infrastructure.Context;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    public class ProprietarioRepository : BaseRepository<Proprietario>, IProprietarioRepository
    {
        public ProprietarioRepository(ApplicationContext context) : base(context)
        {
        }

        public void Set(Proprietario proprietario)
        {
            dbSet.Add(proprietario);
            context.SaveChanges();
        }

        public void Delete(Proprietario proprietario)
        {
            dbSet.Remove(proprietario);
            context.SaveChanges();
        }

        public Proprietario Get(int id)
        {
            return dbSet
                .Include(p => p.endereco)
                .Where(e => e.id == id).SingleOrDefault();
        }

        public void Update(Proprietario proprietario)
        {
            dbSet.Update(proprietario);
            context.SaveChanges();
        }
    }
}
