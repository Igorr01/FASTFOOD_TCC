using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq;
namespace api.Database
{
    public class FuncionarioDatabase
    {
        Models.db_next_gen_booksContext context = new Models.db_next_gen_booksContext();
        public async  Task<Models.TbFuncionario> CadastrarFuncionario(Models.TbFuncionario tabela)
        {
            await context.AddAsync(tabela);
            await context.SaveChangesAsync();
            return tabela;  
        }
         
        public async Task<Models.TbFuncionario> AlterarFuncionario(int idFuncionario,Models.TbFuncionario nova)
        {
            Models.TbFuncionario tabela = await ConsultarFuncionarioPorId(idCliente);
            tabela.NmFuncionario = nova.NmFuncionario;
            tabela.DtNascimento = nova.DtNascimento;
            tabela.DsRg = nova.DsRg;
            tabela.DsCPF = nova.DsCPF;
            tabela.DsEndereco = nova.DsEndereco;
            tabela.NrCelular = nova.NrCelular;
            tabela.NrTelefoneFixo = nova.NrTelefoneFixo;
            
            await context.SaveChangesAsync();

            return tabela;
        }
        public async Task<Models.TbFuncionario> DeletarFuncionario(int id)
        {
            Models.TbFuncionario tabela = await ConsultarFuncionarioporId(id);
            context.TbFuncionario.Remove(tabela);
            await context.SaveChangesAsync();
            return tabela;
        }


        public Task<List<Models.TbFuncionario>> ListarFuncionario()
        {
            return context.TbFuncionario.ToListAsync();
        }

        
        public Task<Models.TbFuncionario> ConsultarFuncionarioPorId(int id)
        {
            return context.TbFuncionario.FirstOrDefaultAsync(x => x.IdCliente == id);
        }
    }
}
