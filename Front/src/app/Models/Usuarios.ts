import { Contactos } from './Contactos';

export class Usuarios{
    constructor(
        public Id:number,
        public Name:string,
        public LastName:string,
        public UserName:string,
        public Password:string,
        public TypeUser:number,
        public Contactos:Contactos[]
    ){

    }
}
