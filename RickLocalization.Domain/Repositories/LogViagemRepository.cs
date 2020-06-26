using RickLocalization.Domain.Context;
using RickLocalization.Domain.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Domain.Repositories {

    public class LogViagemRepository : ILogViagemRepository {

        private readonly AppDBContext _appDBContext;

        public LogViagemRepository(AppDBContext appDBContext) {
            _appDBContext = appDBContext;
        }
    }
}
