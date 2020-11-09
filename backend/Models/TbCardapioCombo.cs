using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_cardapio_combo")]
    public partial class TbCardapioCombo
    {
        [Key]
        [Column("id_combo")]
        public int IdCombo { get; set; }
        [Column("vl_preco", TypeName = "decimal(10,0)")]
        public decimal VlPreco { get; set; }
        [Required]
        [Column("nm_lanche", TypeName = "varchar(100)")]
        public string NmLanche { get; set; }
        [Required]
        [Column("nm_bebida", TypeName = "varchar(100)")]
        public string NmBebida { get; set; }
        [Required]
        [Column("nm_acompanhamento", TypeName = "varchar(100)")]
        public string NmAcompanhamento { get; set; }
    }
}
