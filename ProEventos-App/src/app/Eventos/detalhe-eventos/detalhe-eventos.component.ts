import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-detalhe-eventos',
  templateUrl: './detalhe-eventos.component.html',
  styleUrls: ['./detalhe-eventos.component.scss']
})
export class DetalheEventosComponent implements OnInit {

  form!: FormGroup;

  constructor(
    private fb: FormBuilder
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

  // public Validation(): void {
  
  // }

}
