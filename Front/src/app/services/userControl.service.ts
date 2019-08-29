import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Global } from './global';
import { Observable } from 'rxjs/observable';


@Injectable()
export class UserControlService {

    public url: string;

    constructor(private _httpClient: HttpClient) {

        this.url = Global.url;

    }

    testService() {

        console.log("hoola");

    }
    //Listar usuarios
    
    getAllUsers(): Observable<any> {

        let headers = new HttpHeaders().set("Content-Type", "application/json");
        return this._httpClient.get(this.url+"usuarios", { headers: headers });

    }
    
    //Buscar usuario especifico

    getUsersById(id): Observable<any> {

        let headers = new HttpHeaders().set("Content-Type", "application/json");
        return this._httpClient.get(this.url + "usuarios/" + id, { headers: headers });

    }

    //Borrar Usuario

    deleteUser(id): Observable<any> {

        let headers = new HttpHeaders().set("Content-Type", "application/json");
        return this._httpClient.delete(this.url + "usuarios/" + id, { headers: headers });

    }
}