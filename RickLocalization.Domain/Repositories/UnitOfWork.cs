using RickLocalization.Domain.Context;
using RickLocalization.Domain.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Domain.Repositories {

    public class UnitOfWork : IUnitOfWork {

        private readonly AppDBContext _appDBContext;

        public UnitOfWork(AppDBContext appDBContext) {

            _appDBContext = appDBContext;

            ViajanteRepository = new ViajanteRepository(_appDBContext);
            DimensaoRepository = new DimensaoRepository(_appDBContext);
            LogViagemRepository = new LogViagemRepository(_appDBContext);
        }

        public IViajanteRepository ViajanteRepository { get; private set; }

        public IDimensaoRepository DimensaoRepository { get; private set; }

        public ILogViagemRepository LogViagemRepository { get; private set; }

        public void Dispose() {
            _appDBContext.Dispose();
        }

        public void Save() {
            _appDBContext.SaveChanges();
        }
    }
}
