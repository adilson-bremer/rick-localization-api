using RickLocalization.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RickLocalization.Domain.Repositories.Interface {

    public interface IDimensaoRepository {

        void Add(Dimensao dimensao);

        Task<IEnumerable<Dimensao>> GetAll();
    }
}
