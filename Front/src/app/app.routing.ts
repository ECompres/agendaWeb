import { Routes, RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { HomeComponent } from './components/home/home.component';
import { AddComponent } from './components/add/add.component';
import { EditComponent } from './components/edit/edit.component';
import { ReadComponent } from './components/read/read.component';

import { SearchComponent } from './components/search/search.component';
import { ListComponent } from './components/list/list.component';
import { RegisterComponent } from './components/register/register.component';
import { LoginComponent } from './components/login/login.component';


export const routes: Routes = [
    { path: 'home', component: HomeComponent },
    { path: 'registro', component: RegisterComponent },
    { path: 'login', component: LoginComponent },
    { path: 'agregar', component: AddComponent },
    { path: 'listar', component: ListComponent },
    { path: 'editar/:id', component: EditComponent },
    { path: 'ver/:id', component: ReadComponent },
    { path: 'search/:id', component: SearchComponent },
    { path: '**', redirectTo: 'home' }
];