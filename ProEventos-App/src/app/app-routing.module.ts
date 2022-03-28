import { PerfilComponent } from './User/perfil/perfil.component';
import { NovoUsuarioComponent } from './User/novo-usuario/novo-usuario.component';
import { LoginComponent } from './User/login/login.component';
import { UserComponent } from './User/user/user.component';
import { EventosComponent } from './Eventos/eventos/eventos.component';
import { ListaEventosComponent } from './Eventos/lista-eventos/lista-eventos.component';
import { DetalheEventosComponent } from './Eventos/detalhe-eventos/detalhe-eventos.component';
import { PalestrantesComponent } from './palestrantes/lista-palestrantes/palestrantes.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [

  {
    path: 'user', component: UserComponent,
    children: [
      { path: 'login', component: LoginComponent },
      { path: 'novo-usuario', component: NovoUsuarioComponent }
    ]
  },
  { path: 'user/perfil', component: PerfilComponent },

  { path: 'eventos', redirectTo: 'eventos/lista' },
  {
    path: 'eventos', component: EventosComponent,
    children: [
      { path: 'lista', component: ListaEventosComponent },
      { path: 'detalhe/:id', component: DetalheEventosComponent },
      { path: 'detalhe', component: DetalheEventosComponent }
    ]

  },
  { path: 'lista-palestrantes', component: PalestrantesComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
