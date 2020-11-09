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
    public class FuncionarioController : ControllerBase
    {
        Business.FuncionarioBusiness businessFuncionario = new Business.FuncionarioBusiness();
        Utils.FuncionarioConversor conversor = new Utils.FuncionarioConversor();
        [HttpPut]
        public ActionResult<Models.Response.FastFoodResponse.Funcionario> Alterar(Models.Request.FastFoodResponse.Funcionario req)
        {
            try
            {
                Models.TbFuncionario funcionario = conversor.ConversorTabelaFuncionario(req);
                
                funcionario = businessFuncionario.Alterar(funcionario);

                Models.Response.FastFoodResponse.Funcionario resp = conversor.ConversorTabelaResponse(funcionario);
                
                return resp;
            }
            catch (System.Exception ex)
            {
                return BadRequest(
                    new Models.Response.Erro(400, ex.Message)
                );
            }
        }
        [HttpGet("{IdFuncionario}")]
        public ActionResult<Models.Response.FastFoodResponse.Funcionario> ConsultarInfomacoesDoFuncionario(int IdFuncionario)
        {
            try
            {
                Models.TbFuncionario modeloTabela = businessFuncionario.ConsultarFuncionario(IdFuncionario);
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
                Models.TbFuncionario resp = businessFuncionario.RecuperarSenha(RGeCPF.CPF,RGeCPF.RG);
                return resp.IdLoginNavigation.DsSenha;
            }
            catch (System.Exception ex)
            {
                return NotFound(new Models.Response.Erro(404, ex.Message));
            }
        }
    }
}