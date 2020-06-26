using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RickLocalization.Domain.Entities {

    public class Viajante {

        [Key]
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string Nome { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string Imagem { get; set; }

        [ForeignKey("DimensaoId")]
        public Dimensao Dimensao { get; set; }

        public int DimensaoId { get; set; }

        public DateTime DataCadastro { get; set; }

        public List<LogViagem> LogsViagens { get; set; } = new List<LogViagem>();
    }
}
