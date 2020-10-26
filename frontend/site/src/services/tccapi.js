import axios from 'axios'

const api = axios.create({
    baseURL: "http://3.91.222.255"
})

export default class FastFoodApi {

    async cadastrar(ln) {
        let formData = new FormData();
        formData.append('nome', ln.nome);
        formData.append('motivo', ln.motivo);
        formData.append('local', ln.local);
        formData.append('inclusao', ln.inclusao);
        formData.append('foto', ln.foto);

        const resp = await api.post('/FastFood', formData, {
            headers: { 'content-type': 'multipart/form-data' }
        });
        return resp;
    }

    async consultar() {
        const resp = await api.get('/FastFood');
        
        return resp.data;
    }

    buscarImagem(foto) {
        const urlFoto = api.defaults.baseURL + '/FastFood/foto/' + foto;
        return urlFoto;
    }


    async deletar(id) {
        const resp = await api.delete(`/FastFood/${id}`);
        
        return resp.data;
    }


    async alterar(id, ln) {
        const resp = await api.put(`/FastFood/${id}`, ln);
        
        return resp.data;
    }
}