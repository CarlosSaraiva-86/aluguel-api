using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Interfaces
{
    public interface IImovelRepository
    {
        Imovel Get(int id);
        List<Imovel> GetAll();
        void Set(Imovel imovel);
        void Update(Imovel imovel);
        void Delete(Imovel imovel);
    }
}
