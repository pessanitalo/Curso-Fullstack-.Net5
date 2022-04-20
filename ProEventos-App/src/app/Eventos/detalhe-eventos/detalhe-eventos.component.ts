import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-detalhe-eventos',
  templateUrl: './detalhe-eventos.component.html',
  styleUrls: ['./detalhe-eventos.component.scss']
})
export class DetalheEventosComponent implements OnInit {

  form!: FormGroup;

  constructor(
    private fb: FormBuilder,
    private router:ActivatedRoute
  ) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      local: [''],
      dataEvento: [''],
      tema: [''],
      QtdPessoa: [''],
      ImagemUrl: [''],
      Telefone: [''],
      email: ['']
    });
  }

  public carregarEvento(): void{
    const eventoId = +this.router.snapshot.paramMap.get('id');
    if(eventoId !== null){

    }
  }
 }
