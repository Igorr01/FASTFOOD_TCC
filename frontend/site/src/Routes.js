import React from 'react';
import { Switch, BrowserRouter, Route } from 'react-router-dom';

import Inicio from './pages/Menu';
import Cadastrar from './pages/Cadastrar';
import Consultar from './pages/Consultar';

export default function Routes() {
    return(
        <BrowserRouter>
            <Switch>
                <Route path="/" exact={true} component={Inicio} />
                <Route path="/Cadastrar" component={Cadastrar}  />
                <Route path="/Consultar" component={Consultar}  />
            </Switch>
        </BrowserRouter>
    )
}   