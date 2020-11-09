using System;

namespace backend.Models.Response
{
    public class TestDriveResponse
    {
        public class Login
        {
            public int IdLogin { get; set; }
            public string email { get; set; }
            public string senha { get; set; }

        }

        public class Cliente
        {
            public int IdCliente { get; set; }
            public int IdLogin { get; set; }
            public string Nome { get; set; }
            public DateTime DataDeNascimento { get; set; }
            public string Endereco { get; set; }
            public string CPF { get; set; }
            public string Celular { get; set; }
        }


        public class CardapioCombo
        {
            public int IdCardapioCombo { get; set; }
            public decimal preco { get; set; }
            public string lanche { get; set; }
            public string bebida { get; set; }
            public string acompanhamento { get; set; }
            public List<Imagem> Imagens { get; set; }
        }

        public class Cardapio
        {
            public int IdCardapio { get; set; }
            public decimal preco { get; set; }
            public string lanche { get; set; }
            public string bebida { get; set; }
            public string acompanhamento { get; set; }
            public List<Imagem> Imagens { get; set; }
        }


    }
}
