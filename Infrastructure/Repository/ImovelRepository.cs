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
    public class ImovelRepository : BaseRepository<Imovel>, IImovelRepository
    {
        public ImovelRepository(ApplicationContext context) : base(context)
        {
        }

        public void Delete(Imovel imovel)
        {
            dbSet.Remove(imovel);
            context.SaveChanges();
        }

        public Imovel Get(int id)
        {
            return dbSet
                .Include(p => p.endereco)
                .Include(p => p.proprietario)
                .Where(e => e.id == id).SingleOrDefault();
        }

        public List<Imovel> GetAll()
        {
            return dbSet
                .Include(p => p.endereco)
                .Include(p => p.proprietario)
                .ToList();
        }

        public void Set(Imovel imovel)
        {
            dbSet.Add(imovel);
            context.SaveChanges();
        }

        public void Update(Imovel imovel)
        {
            dbSet.Update(imovel);
            context.SaveChanges();
        }
    }
}
