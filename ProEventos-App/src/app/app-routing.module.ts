import { EventosComponent } from './Eventos/eventos/eventos.component';
import { ListaEventosComponent } from './Eventos/lista-eventos/lista-eventos.component';
import { DetalheEventosComponent } from './Eventos/detalhe-eventos/detalhe-eventos.component';
import { PalestrantesComponent } from './palestrantes/lista-palestrantes/palestrantes.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path: 'eventos', redirectTo: 'eventos/lista'},
  {
    path: 'eventos', component: EventosComponent,
    children: [
      { path: 'lista', component: ListaEventosComponent },
      { path: 'detalhe:id', component: DetalheEventosComponent },
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
