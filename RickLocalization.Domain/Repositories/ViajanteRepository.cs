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

    public class ViajanteRepository : IViajanteRepository {

        private readonly AppDBContext _appDBContext;

        public ViajanteRepository(AppDBContext appDBContext) {
            _appDBContext = appDBContext;
        }

        public async Task<IEnumerable<Viajante>> GetAllAsync() {
            return await _appDBContext.Viajantes.ToListAsync();
        }

        public Viajante Get(int id) {
            return _appDBContext.Viajantes.Where(v => v.Id == id).Include(v => v.Dimensao).SingleOrDefault();
        }
    }
}
