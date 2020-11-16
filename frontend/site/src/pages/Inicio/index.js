import React from 'react';
import './index.css';

export default function Inicio() {
    return(
        <div>
            <ul>
                <li><a class="active" href="#">Inicio</a></li>
                <li><a href="#">Cardapio</a></li>
                <li><a href="#">Cadastre-se</a></li>
                <li><a href="#">Consultar</a></li>
            </ul>

            <div className="conteudo">
                <div className="containercadastro">
                    <h1 className="titulocadastro">Realize seu cadastro!</h1>
                    <button class="button button2">Cadastre-se aqui</button>
                </div>

                <div className="containercardapio">
                    <div className="minicontainercardapio">
                        <h1 className="titulocardapio">Acesse nosso Cardapio!</h1>
                        <button class="button button2">Nosso Cardapio</button>
                    </div>
                </div>

                <div className="containerconsultar">
                    <h1 className="tituloconsulta">Consulte seu cadastro</h1>
                    <button class="button button2">Nosso Cardapio</button>
                </div>
            </div>

        </div>
    )
}