using RickLocalization.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RickLocalization.Domain.Repositories.Interface {

    public interface IViajanteRepository {

        Task<IEnumerable<Viajante>> GetAllAsync();
    }
}
