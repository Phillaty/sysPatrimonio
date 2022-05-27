﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SysPatrimonio.Models
{
    [Table("patrimonio", Schema="public")]
    public class DbPatrimonio
    {
        [Key]

        public int id { get; set; }
        public int numetiqueta { get; set; }
        public string nomepatrimonio { get; set; }
        public string descricaopatrimonio { get; set; }
        public decimal valorpatrimonio { get; set; }
        public int idcategoria { get; set; }
        public int idlocal { get; set; }
        public int iddepartamento { get; set; }
        public string marcamodelo { get; set; }
        public DateTime dataquisicao { get; set; }
        public DateTime databaixa { get; set; }
    }
}
