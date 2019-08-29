import { Usuarios } from './Usuarios';

export class Contactos{
    constructor(
        public Id:number,
        public ContactName:string,
        public ContactLastName:string,
        public TelephoneNumber:string,
        public UsuarioId:number,
        public Usuario:Usuarios
    ){

    }
}
