using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Api.Models {

    public class LogViagemCreateDto {

        public int ViajanteId { get; set; }

        public int DimensaoOrigemId { get; set; }

        public int DimensaoDestinoId { get; set; }

        public DateTime DataViagem { get; set; }
    }
}
