import { FormGroup, FormBuilder, AbstractControlOptions } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { ValidatorField } from 'src/app/shared/helpers/ValidatorsField';

@Component({
  selector: 'app-novo-usuario',
  templateUrl: './novo-usuario.component.html',
  styleUrls: ['./novo-usuario.component.scss']
})
export class NovoUsuarioComponent implements OnInit {

  form!: FormGroup;

  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {

    const formOptions: AbstractControlOptions = {
      validators: ValidatorField.MustMatch('senha', 'confirmeSenha')
    };

    this.form = this.fb.group({
      primeiroNome: [''],
      ultimoNome: [''],
      email: [''],
      userName: [''],
      senha: [''],
      confirmeSenha: [''],
    }, formOptions);
  }

}
