using System;

namespace RickLocalization.Domain.Entities {

    public class LogViagemDto {

        public int Id { get; set; }

        public string Origem { get; set; }

        public string Destino { get; set; }

        public DateTime DataViagem { get; set; }
    }
}
