import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetalheEventosComponent } from './detalhe-eventos.component';

describe('DetalheEventosComponent', () => {
  let component: DetalheEventosComponent;
  let fixture: ComponentFixture<DetalheEventosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetalheEventosComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DetalheEventosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
