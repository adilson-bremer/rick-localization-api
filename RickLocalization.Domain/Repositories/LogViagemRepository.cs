﻿using Dapper;
using Microsoft.Data.SqlClient;
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

    public class LogViagemRepository : ILogViagemRepository {

        private readonly AppDBContext _appDBContext;

        private readonly string CONNECTION_STRING = AppValues.SQLSERVER_CONNECTION_STRING;

        public LogViagemRepository(AppDBContext appDBContext) {
            _appDBContext = appDBContext;
        }

        public IEnumerable<LogViagemDto> GetLogsByViajante(int id) {

            string sql = @"SELECT l.Id, do.Nome AS Origem, dd.Nome AS Destino, l.DataViagem FROM LogsViagens l 
                            INNER JOIN Dimensoes do ON l.DimensaoOrigemId = do.Id
                            INNER JOIN Dimensoes dd ON l.DimensaoDestinoId = dd.Id
                            WHERE l.ViajanteId = @ViajanteId ORDER BY l.DataViagem DESC";

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING)) {

                List<LogViagemDto> result = connection.Query<LogViagemDto>(sql, new { ViajanteId = id }).ToList();

                return result;
            }
        }

        public void Add(LogViagem logViagem) {
            _appDBContext.LogsViagens.Add(logViagem);
        }
    }
}
