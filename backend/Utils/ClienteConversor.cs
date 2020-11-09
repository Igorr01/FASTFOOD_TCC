using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Backend.Utils
{
    public class ClienteConversor
    {
        public Models.TbCliente ClienteTabelaUsuario (Models.Request.FastFoodRequest.Cliente req)
        {
            Models.TbCliente cliente = new Models.TbCliente();
            cliente.IdCliente = req.IdCliente;
            cliente.IdLoginNavigation = new Models.TbLogin(){
    
            };
            cliente.NmCliente = req.NomeCliente;
            cliente.DtNascimento = req.DataDeNascimento;
            cliente.DsEndereco = req.Endereco;
            cliente.NrCelular = req.Celular;

            return cliente;
        }

        public Models.Response.FastFoodRequest.Cliente ConversorTabelaResponse(Models.TbCliente entrada)
        {
            Models.Response.FastFoodResponse.Cliente resp = new Models.Response.FastFoodResponse.Cliente();
            resp.IdCliente = entrada.IdCliente;
            resp.IdLogin = entrada.IdLogin;
            resp.Perfil = entrada.IdLoginNavigation.DsPerfil;
            resp.Senha = entrada.IdLoginNavigation.DsSenha;
            resp.NomeCliente = entrada.NmCliente;
            resp.DataDeNascimento = entrada.DtNascimento;
            resp.CPF = entrada.DsCpf;
            resp.Email = entrada.DsEmail;
            resp.Celular = entrada.NrCelular;
            resp.Endereco = entrada.DsEndereco;

            return resp;
        }
    }
}
