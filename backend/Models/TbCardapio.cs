using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_cardapio")]
    public partial class TbCardapio
    {
        public TbCardapio()
        {
            TbPedido = new HashSet<TbPedido>();
        }

        [Key]
        [Column("id_cardapio")]
        public int IdCardapio { get; set; }
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

        [InverseProperty("IdCardapioNavigation")]
        public virtual ICollection<TbPedido> TbPedido { get; set; }
    }
}
