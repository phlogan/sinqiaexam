import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl, FormsModule } from '@angular/forms';
import { MovimentosService } from '../services/MovimentosManuaisService';
import { ProdutoService } from '../services/ProdutoService';

@Component({
  selector: 'movimentos-manuais-form',
  imports: [FormsModule, HttpClientModule],
  templateUrl: 'movimentos-manuais-form.component.html',
  styles: ``
})
export class MovimentosManuaisFormComponent {
  constructor(private http: HttpClient, private movimentosService: MovimentosService, private produtoService: ProdutoService) {}

  Data_mes: number = 0;
  Data_ano: number = 0;
  Cod_Produto: string = '';
  Cod_Cosif: string = '';
  Val_valor: number = 0;
  Des_Descricao: string = '';

  Errors: string[] = [];

  Produtos: [string, string][] = [];
  Cosifs: [string, string][] = [];
  fieldsDisabled:boolean = true;
  cosifsDisabled:boolean = true;
  
  ngOnInit() {
    this.loadProdutos();
  }

  include() {
    this.Errors = [];
    
    const movimentoManual = {
      Data_mes: this.Data_mes,
      Data_ano: this.Data_ano,
      Cod_Produto: this.Cod_Produto,
      Cod_Cosif: this.Cod_Cosif,
      Val_valor: this.Val_valor,
      Des_Descricao: this.Des_Descricao,
    };
    
    this.movimentosService.include(movimentoManual)
    .subscribe({
      next: (response) =>{
        this.movimentosService.fetchData();
        this.clear();
        this.fieldsDisabled = true;
      },
      error: (err) =>{
        if(err.status == 500){
          this.Errors.push("Erro interno do servidor. Tente novamente mais tarde.")
        }else{
          this.Errors = err.error.errorList;
        }
      }
    });
  }

  loadProdutos() {
    this.produtoService.getProdutos().subscribe({
      next: (data) => {
        this.Produtos = Object.entries(data);;
      },
      error: (err) => {
        this.Errors.push("Erro ao carregar produtos. Tente novamente mais tarde.")
      },
    });
  }
  
  onCod_ProdutoChange() {
    this.cosifsDisabled = true;
    this.produtoService.getCosifsByProduto(this.Cod_Produto).subscribe({
      next: (data) => {
        this.Cosifs = Object.entries(data);
        this.cosifsDisabled = false;
      },
      error: (err) => {
        this.Errors.push("Erro ao carregar cosifs. Tente novamente mais tarde.");
      }
    });
  }

  clear() {
    this.Data_mes = 0;
    this.Data_ano = 0;
    this.Cod_Produto = '';
    this.Cod_Cosif = '';
    this.Val_valor = 0;
    this.Des_Descricao = '';
  }

  new(){
    this.fieldsDisabled = false;
  }
}
