import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class MovimentosService {
  private movimentosSubject = new BehaviorSubject<any[]>([]);
  movimentos$ = this.movimentosSubject.asObservable();

  constructor(private http: HttpClient) {}

  fetchData() {
    this.http.get<any[]>('https://localhost:44393/api/movimentos_manuais')
      .subscribe({
        next: (data) => {
            this.movimentosSubject.next(data);
        },
        error: (err) => {
          console.error('Error fetching data', err);
        }
      });
  }

  include(movimentoManual: any): Observable<any> {
    return this.http.post('https://localhost:44393/api/movimentos_manuais', movimentoManual,{
      headers: { 'Accept': 'application/json' }
    });
  }

}
