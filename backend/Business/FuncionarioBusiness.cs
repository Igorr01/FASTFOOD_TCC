using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace api.Business
{
    public class FuncionarioBusiness : Validador.ValidadorFuncionario
    {
        Database.FuncionarioDatabase database = new Database.FuncionarioDatabase(); 
        public async Task<Models.TbFuncionario> CadastrarFuncionario(Models.TbFuncionario tabela)
        {
            ValidarFuncionario(tabela);
            return await database.CadastrarFuncionario(tabela);
        }

        public async Task<Models.TbFuncionario> AlterarFuncionario(int idFuncionario,Models.TbFuncionario tabela)
        {
            ValidarFuncionarioAlterar(tabela);
            return await database.AlterarFuncionario(idFuncionario,tabela);
        }
        public async Task<Models.TbFuncionario> ValidarDeletarFuncionario(int id)
        {
            ValidarFuncionarioExiste(id);
            return await database.DeletarFuncionario(id);
        }
        public async Task<Models.TbFuncionario> ValidarConsultaPorId(int id)
        {
            ValidarFuncionarioExiste(id);
            return await database.ConsultarFuncionarioPorId(id);
        }
        public async Task<List<Models.TbFuncionario>> ValidarListarFuncionario()
        {
            return await database.ListarFuncionario();
        }
    }
}