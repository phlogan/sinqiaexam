import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ProdutoService {
  private baseUrl = 'https://localhost:44393/api/produto';

  constructor(private http: HttpClient) {}

  getProdutos(): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}/enumerate`);
  }

  getCosifsByProduto(cod_produto: string): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}/enumerate/cosif/${cod_produto}`);
  }
}