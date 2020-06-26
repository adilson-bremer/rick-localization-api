using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RickLocalization.Domain.Entities {

    public class LogViagem {

        [Key]
        public int Id { get; set; }

        [ForeignKey("ViajanteId")]
        public Viajante Viajante { get; set; }

        public int ViajanteId { get; set; }

        public int DimensaoOrigemId { get; set; }

        public int DimensaoDestinoId { get; set; }

        public DateTime DataViagem { get; set; }
    }
}
