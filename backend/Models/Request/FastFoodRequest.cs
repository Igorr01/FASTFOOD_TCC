using System;

namespace backend.Models.Request
{
    public class FastFoodRequest
    {
        public class Login
        {
            public string email { get; set; }
            public string senha { get; set; }
        }  

        public class Cliente
        {
            public string Nome { get; set; }
            public DateTime? DataDeNascimento { get; set; }
            public string Endereco { get; set; }
            public string CPF { get; set; }
            public string Celular { get; set; }
        }

        public class CardapioCombo
        {
            public decimal? preco { get; set; }
            public string lanche { get; set; }
            public string bebida { get; set; }
            public string acompanhamento { get; set; }
            public List<Imagem> Imagens { get; set; }
        }

        public class Cardapio
        {
            public decimal? preco { get; set; }
            public string lanche { get; set; }
            public string bebida { get; set; }
            public string acompanhamento { get; set; }
            public List<Imagem> Imagens { get; set; }
        }
    }
}