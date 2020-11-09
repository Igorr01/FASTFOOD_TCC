using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        Business.ClienteBusiness businessCliente = new Business.ClienteBusiness();
        Utils.ClienteConversor conversor = new Utils.ClienteConversor();
        [HttpPut]
        public ActionResult<Models.Response.FastFoodResponse.Cliente> Alterar(Models.Request.FastFoodRequest.Cliente req)
        {
            try
            {
                Models.TbCliente cliente = conversor.ConversorTabelaCliente(req);
                
                cliente = businessCliente.Alterar(cliente);

                Models.Response.FastFoodResponse.Cliente resp = conversor.ConversorTabelaResponse(Cliente);
                
                return resp;
            }
            catch (System.Exception ex)
            {
                return BadRequest(
                    new Models.Response.Erro(400, ex.Message)
                );
            }
        }
        [HttpGet("{IdCliente}")]
        public ActionResult<Models.Response.FastFoodResponse.Cliente> ConsultarInfomacoesDoCliente(int IdCliente)
        {
            try
            {
                Models.TbCliente modeloTabela = businessCliente.ConsultarCliente(IdCliente);
                return conversor.ConversorTabelaResponse(modeloTabela);
            }
            catch (System.Exception ex)
            {
                return NotFound(new Models.Response.Erro(404, ex.Message));
            }
        }
        [HttpPost("RecuperarSenha")]
        public ActionResult<string> RecuperarSenha(Models.Request.FastFoodRequest.Recuperação RGeCPF)
        {
            try
            {
                Models.TbCliente resp = businessCliente.RecuperarSenha(RGeCPF.CPF,RGeCPF.RG);
                return resp.IdLoginNavigation.DsSenha;
            }
            catch (System.Exception ex)
            {
                return NotFound(new Models.Response.Erro(404, ex.Message));
            }
        }
    }
}