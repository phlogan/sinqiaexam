import { Component } from '@angular/core';
import { MovimentosManuaisFormComponent } from '../movimentos-manuais-form/movimentos-manuais-form.component';
import { MovimentosManuaisListComponent } from '../movimentos-manuais-list/movimentos-manuais-list.component';

@Component({
  selector: 'app-root',
  imports: [MovimentosManuaisFormComponent, MovimentosManuaisListComponent],
  templateUrl: 'app.component.html'
})
export class AppComponent {
  title = 'sinqia_exam_angular';
}
