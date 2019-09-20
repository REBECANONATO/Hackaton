﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Hackaton.Dominio.hackaton
{
    [Table("pessoa", Schema = "hackaton")]
    public class Pessoa
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("email")]
        public string Email { get; set; }
    }
}
