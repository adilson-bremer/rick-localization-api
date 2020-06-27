using RickLocalization.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RickLocalization.Domain.Repositories.Interface {

    public interface ILogViagemRepository {

        void Add(LogViagem logViagem);

        IEnumerable<LogViagemDto> GetLogsByViajante(int id);
    }
}
