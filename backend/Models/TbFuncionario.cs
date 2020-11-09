using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_funcionario")]
    public partial class TbFuncionario
    {
        [Key]
        [Column("if_funcionario")]
        public int IfFuncionario { get; set; }
        [Column("id_login")]
        public int IdLogin { get; set; }
        [Required]
        [Column("nm_funcionario", TypeName = "varchar(100)")]
        public string NmFuncionario { get; set; }
        [Column("dt_nascimento", TypeName = "date")]
        public DateTime DtNascimento { get; set; }
        [Required]
        [Column("ds_rg", TypeName = "varchar(20)")]
        public string DsRg { get; set; }
        [Required]
        [Column("ds_CPF", TypeName = "varchar(20)")]
        public string DsCpf { get; set; }
        [Required]
        [Column("ds_endereco", TypeName = "varchar(100)")]
        public string DsEndereco { get; set; }
        [Required]
        [Column("nr_celular", TypeName = "varchar(20)")]
        public string NrCelular { get; set; }
        [Column("nr_telefone_fixo", TypeName = "varchar(20)")]
        public string NrTelefoneFixo { get; set; }

        [ForeignKey(nameof(IdLogin))]
        [InverseProperty(nameof(TbLogin.TbFuncionario))]
        public virtual TbLogin IdLoginNavigation { get; set; }
    }
}
