using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_pedido")]
    public partial class TbPedido
    {
        [Key]
        [Column("id_pedido")]
        public int IdPedido { get; set; }
        [Column("id_login")]
        public int IdLogin { get; set; }
        [Column("id_cardapio")]
        public int? IdCardapio { get; set; }
        [Column("id_combo")]
        public int? IdCombo { get; set; }
        [Column("vl_preco", TypeName = "decimal(10,0)")]
        public decimal? VlPreco { get; set; }

        [ForeignKey(nameof(IdCardapio))]
        [InverseProperty(nameof(TbCardapio.TbPedido))]
        public virtual TbCardapio IdCardapioNavigation { get; set; }
        [ForeignKey(nameof(IdLogin))]
        [InverseProperty(nameof(TbLogin.TbPedido))]
        public virtual TbLogin IdLoginNavigation { get; set; }
    }
}
