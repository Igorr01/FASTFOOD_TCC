using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Backend.Business
{
    public class Validadores
    {
        public void VerificarLogin(Models.TbLogin tabela)
        {
            if(tabela == null) throw new ArgumentException("Email ou senha incorretos.");
                
            ValidarTexto(tabela.DsEmail);
            ValidarTexto(tabela.DsSenha);  
        }

        public void Alterar(Models.TbCliente Cliente)
        {
            ValidarTexto(usuario.NmUsuario);
            ValidarTexto(usuario.DsEmail);
            ValidarTexto(usuario.DsCelular);
            ValidarTexto(usuario.DsCep);
            ValidarTexto(usuario.DsEndereco);
            ValidarData(usuario.DtNascimento);
            ValidarId(usuario.IdUsuario);
            ValidarTexto(usuario.IdLoginNavigation.DsSenha);
            ValidarTexto(usuario.IdLoginNavigation.DsUsername);
        }

        public void Alterar(Models.TbFuncionario Funcionario)
        {
            ValidarTexto(usuario.NmUsuario);
            ValidarTexto(usuario.DsEmail);
            ValidarTexto(usuario.DsCelular);
            ValidarTexto(usuario.DsCep);
            ValidarTexto(usuario.DsEndereco);
            ValidarData(usuario.DtNascimento);
            ValidarId(usuario.IdUsuario);
            ValidarTexto(usuario.IdLoginNavigation.DsSenha);
            ValidarTexto(usuario.IdLoginNavigation.DsUsername);
        }

        public void Cadastrar(Models.TbLogin req, string ConfirmarSenha)
        {
            if(req.DsSenha != ConfirmarSenha) throw new ArgumentException("Senhas diferente. Tente conferir a senha novamente.");
            ValidarTexto(req.DsUsername);
            ValidarTexto(req.DsUsername);
            ValidarTexto(req.TbUsuario.FirstOrDefault().NmUsuario);
            ValidarTexto(req.TbUsuario.FirstOrDefault().DsEmail);
            ValidarData(req.TbUsuario.FirstOrDefault().DtNascimento);
            ValidarTexto(req.TbUsuario.FirstOrDefault().DsSexo);
            ValidarTexto(req.TbUsuario.FirstOrDefault().DsCpf);
            ValidarTexto(req.TbUsuario.FirstOrDefault().DsRg);
            ValidarTexto(req.TbUsuario.FirstOrDefault().DsCelular);
            ValidarTexto(req.TbUsuario.FirstOrDefault().DsEstado);
            ValidarTexto(req.TbUsuario.FirstOrDefault().DsCidade);
            ValidarTexto(req.TbUsuario.FirstOrDefault().DsCep);
            ValidarTexto(req.TbUsuario.FirstOrDefault().DsBairro);
            ValidarTexto(req.TbUsuario.FirstOrDefault().DsNEndereco);
            ValidarTexto(req.TbUsuario.FirstOrDefault().DsEndereco);
            ValidarTermos(req.TbUsuario.FirstOrDefault().BtConcordoTermos);
            if(req.TbUsuario.FirstOrDefault().DsCpf.Length > 14) throw new ArgumentException("CPF incorreto.");
            if(req.TbUsuario.FirstOrDefault().DsCpf.Length < 14) throw new ArgumentException("CPF incorreto.");
        }
        public void RecuperarSenha(string CPF, string RG)
        {
            ValidarTexto(CPF);
            ValidarTexto(RG);
        }

        public void ValidarPreco(decimal? preco)
        {
            if(preco == null || preco == 0.00m) throw new ArgumentException("Verifique o preço.");    
        }
        public void ValidarTexto(string texto)
        {
            if(string.IsNullOrEmpty(texto)) throw new ArgumentException("Campo obrigatorio.");    
        }
        public void ValidarId(int? id)
        {
            if(id <= 0) throw new ArgumentException("Id inválido.");
        }

    }
}