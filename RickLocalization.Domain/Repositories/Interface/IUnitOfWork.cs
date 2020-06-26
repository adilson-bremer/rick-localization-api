using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Domain.Repositories.Interface {

    public interface IUnitOfWork : IDisposable {

        IViajanteRepository ViajanteRepository { get; }

        IDimensaoRepository DimensaoRepository { get; }

        ILogViagemRepository LogViagemRepository { get; }

        void Save();
    }
}
