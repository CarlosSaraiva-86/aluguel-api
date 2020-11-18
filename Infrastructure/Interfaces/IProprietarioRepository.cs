using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Interfaces
{
    public interface IProprietarioRepository
    {
        Proprietario Get(int id);
        void Set(Proprietario proprietario);
        void Delete(Proprietario proprietario);
        void Update(Proprietario proprietario);
    }
}
