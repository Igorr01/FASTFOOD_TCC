using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Backend.Utils
{
    public class FuncionarioConversor
    {
        public Models.TbFuncionario ClienteTabelaFuncionario (Models.Request.FastFoodRequest.Funcionario req)
        {
            Models.TbFuncionario funcionario = new Models.TbFuncionario();
            funcionario.IdCliente = req.IdCliente;
            funcionario.IdLoginNavigation = new Models.TbLogin(){
    
            };
            funcionario.NmCliente = req.NomeCliente;
            funcionario.DtNascimento = req.DataDeNascimento;
            funcionario.DsEndereco = req.Endereco;
            funcionario.NrCelular = req.Celular;

            return funcionario;
        }

        public Models.Response.FastFoodResponse.Funcionario ConversorTabelaResponse(Models.TbFuncionario entrada)
        {
            Models.Response.FastFoodResponse.Funcionario resp = new Models.Response.FastFoodRoupasResponse.Funcionario();
            resp.IdFuncionario = entrada.IdFuncionario;
            resp.IdLogin = entrada.IdLogin;
            resp.Perfil = entrada.IdLoginNavigation.DsPerfil;
            resp.Senha = entrada.IdLoginNavigation.DsSenha;
            resp.NomeFuncionario = entrada.NmFuncionario;
            resp.DataDeNascimento = entrada.DtNascimento;
            resp.CPF = entrada.DsCpf;
            resp.Rg = entrada.DsRg;
            resp.Email = entrada.DsEmail;
            resp.Celular = entrada.NrCelular;
            resp.Endereco = entrada.DsEndereco;

            return resp;
        }
    }
}
