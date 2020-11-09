using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Backend.Database
{
    public class LoginDatabase
    {
        Models.FastFoodContext ctx = new Models.FastFoodContext();
        public Models.TbLogin Logar(Models.TbLogin request)
        {
            Models.TbLogin resp = ctx.TbLogin.Include(x => x.TbUsuario).FirstOrDefault(x => x.DsSenha == request.DsSenha && x.DsEmail == request.DsEmail);
            return resp;
        }
        public Models.TbLogin Cadastrar(Models.TbLogin request)
        {
            ctx.Add(request);
            ctx.SaveChanges();
            return request;
        }
    }
}