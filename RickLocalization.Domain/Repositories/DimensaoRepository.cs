using Microsoft.EntityFrameworkCore;
using RickLocalization.Domain.Context;
using RickLocalization.Domain.Entities;
using RickLocalization.Domain.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickLocalization.Domain.Repositories {

    public class DimensaoRepository : IDimensaoRepository {

        private readonly AppDBContext _appDBContext;

        public DimensaoRepository(AppDBContext appDBContext) {
            _appDBContext = appDBContext;
        }

        public async Task<IEnumerable<Dimensao>> GetAll() {
            return await _appDBContext.Dimensoes.OrderBy(d => d.Nome).ToListAsync();
        }

        public void Add(Dimensao dimensao) {
            _appDBContext.Dimensoes.Add(dimensao);
        }
    }
}
