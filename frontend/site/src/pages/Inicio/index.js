import React from 'react';
import './index.css'

export default function Inicio() {
  return(
    <div>
      <ul>
        <li><a class="active" href="#Inicio">Inicio</a></li>
        <li><a href="#Cadastrar">Cadastrar</a></li>
        <li><a href="#Login">Login</a></li>
        <li><a href="#Consultar">Consultar</a></li>
      </ul>

      <div className="containerLogin">
        <h1 className="titulologin">Faça seu login aqui!</h1>
        <div className="boxbotao3">
        <button class="button button3">Login</button>
        </div>
        <h2 className="paragrafologin">Isso facilitará nosso contato</h2>
      </div>

      <div className="containerCardapio">
        <h1 className="titulocardapio">Acesse nosso cardapio!</h1>
        <div className="boxbotao">
        <button class="button button3">Aqui!</button>
        </div>
        <h2 className="paragrafocardapio">Há muitas variedades em nosso cardapio!</h2>
      </div>

      <div className="containerCadastro">
        <h1 className="titulocadastro">Cadastre-se aqui!</h1>
        <div className="boxbotao2">
        <button class="button button3">Cadastro</button>
        </div>
        <h2 className="paragrafocadastro">Seus dados estarão seguros</h2>
      </div>

    </div>
  )
}