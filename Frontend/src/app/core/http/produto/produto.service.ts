import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Produto } from 'src/app/shared/models/produto';


@Injectable({
  providedIn: 'root'
})
export class ProdutoService {

  private server: string;

  constructor(
    protected http: HttpClient,
  ) {
    this.server = environment.serverUrl;
  }

  obterProdutos(nome: string = ""){
    var url = this.server + '/v1/produto/';
    return this.http.get<Produto[]>(url);
  }
}
