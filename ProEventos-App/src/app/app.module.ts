import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PalestrantesComponent } from './palestrantes/lista-palestrantes/palestrantes.component';
import { NavBarComponent } from './shared/nav-bar/nav-bar.component';
import { FormsModule } from '@angular/forms';
import { NgxMaskModule } from 'ngx-mask';
import { ModalModule } from 'ngx-bootstrap/modal';
import { ToastrModule } from 'ngx-toastr';
import { NgxSpinnerModule } from 'ngx-spinner';
import { TituloComponent } from './shared/titulo/titulo.component';
import { DetalheEventosComponent } from './Eventos/detalhe-eventos/detalhe-eventos.component';
import { ListaEventosComponent } from './Eventos/lista-eventos/lista-eventos.component';
import { EventosComponent } from './Eventos/eventos/eventos.component';
import { UserComponent } from './User/user/user.component';
import { LoginComponent } from './User/login/login.component';
import { NovoUsuarioComponent } from './User/novo-usuario/novo-usuario.component';
import { PerfilComponent } from './User/perfil/perfil.component';

@NgModule({
  declarations: [
    AppComponent,
    PalestrantesComponent,
    NavBarComponent,
    TituloComponent,
    DetalheEventosComponent,
    ListaEventosComponent,
    EventosComponent,
    UserComponent,
    LoginComponent,
    NovoUsuarioComponent,
    PerfilComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    NgxMaskModule.forRoot(),
    ModalModule.forRoot(),
    NgxSpinnerModule,
    ToastrModule.forRoot({
      timeOut: 5000,
      positionClass: 'toast-top-right',
      preventDuplicates: true,
      progressBar: true
    })
  ],
  providers: [],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class AppModule { }
