using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RickLocalization.Domain.Entities {

    public class Dimensao {

        [Key]
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string Nome { get; set; }

        [Column(TypeName = "VARCHAR(1000)")]
        public string Descricao { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
