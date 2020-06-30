using Microsoft.EntityFrameworkCore;
using RickLocalization.Domain.Context;
using RickLocalization.Domain.Entities;
using RickLocalization.Domain.Repositories;
using RickLocalization.Domain.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace RickLocalization.Test {

    public class DimensaoTest {

        [Fact]
        public async Task GetDimensoesAsyncTest() {

            var context = GetAppDbContext();

            IUnitOfWork unitOfWork = new UnitOfWork(context);

            Seed(context);

            IEnumerable<Dimensao> dimensoes = await unitOfWork.DimensaoRepository.GetAll();

            Assert.True(dimensoes.Any());
        }

        [Theory]
        [InlineData("Dimensao X", "Descricao X", true)]
        [InlineData("Dimensao Y", "Descricao Y", true)]
        [InlineData("Dimensao Z", "Descricao Z", true)]
        public void AddDimensaoTest(string nome, string descricao, bool sucesso) {

            var context = GetAppDbContext();

            IUnitOfWork unitOfWork = new UnitOfWork(context);

            Dimensao dimensao = new Dimensao {
                Nome = nome,
                Descricao = descricao,
                DataCadastro = DateTime.Now
            };

            unitOfWork.DimensaoRepository.Add(dimensao);

            Assert.True(sucesso);
        }

        private void Seed(AppDBContext context) {

            var dimensoes = new[] {
                new Dimensao { Nome = "Dimension 1", Descricao = "Lorem Ipsum Dolor Sit Amet"},
                new Dimensao { Nome = "Dimension 2", Descricao = "Lorem Ipsum Dolor Sit Amet"},
                new Dimensao { Nome = "Dimension 3", Descricao = "Lorem Ipsum Dolor Sit Amet"},
                new Dimensao { Nome = "Dimension 4", Descricao = "Lorem Ipsum Dolor Sit Amet"},
                new Dimensao { Nome = "Dimension 5", Descricao = "Lorem Ipsum Dolor Sit Amet"},
                new Dimensao { Nome = "Dimension 6", Descricao = "Lorem Ipsum Dolor Sit Amet"},
            };

            context.Dimensoes.AddRange(dimensoes);
            context.SaveChanges();
        }

        private AppDBContext GetAppDbContext() {

            var options = new DbContextOptionsBuilder<AppDBContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var context = new AppDBContext(options);

            return context;
        }
    }
}
