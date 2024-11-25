import { Component } from '@angular/core';
import { MovimentosService } from '../services/MovimentosManuaisService';

@Component({
  selector: 'movimentos-manuais-list',
  imports: [],
  templateUrl: 'movimentos-manuais-list.component.html',
  styles: ``
})
export class MovimentosManuaisListComponent {
  constructor(private movimentosService: MovimentosService) {}
  movimentosManuais: any[] = [];

  ngOnInit() {
    this.movimentosService.movimentos$.subscribe(data => {
      this.movimentosManuais = data;
    });

    this.movimentosService.fetchData();
  }
}