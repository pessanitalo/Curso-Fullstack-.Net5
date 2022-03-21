import { PalestrantesComponent } from './palestrantes/lista-palestrantes/palestrantes.component';
import { EventosComponent } from './Eventos/lista-eventos/eventos.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: 'lista-eventos', component: EventosComponent },
  { path: 'lista-palestrantes', component: PalestrantesComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
