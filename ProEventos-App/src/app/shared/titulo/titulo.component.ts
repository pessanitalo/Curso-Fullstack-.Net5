import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-titulo',
  templateUrl: './titulo.component.html',
  styleUrls: ['./titulo.component.scss']
})
export class TituloComponent implements OnInit {

  @Input() titulo!: string;
  @Input() iconClass!: string;
  @Input() botaoListar!: boolean;

  constructor(private route: Router) { }

  ngOnInit(): void {
  }

  listar(): void{
    this.route.navigate([`/${this.titulo.toLowerCase()}/lista`]);
  }

}
