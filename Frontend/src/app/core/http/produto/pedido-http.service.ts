import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Produto } from 'src/app/shared/models/produto';
import { Pedido } from 'src/app/shared/models/pedido';


@Injectable({
  providedIn: 'root'
})
export class PedidoHttpService {

  private server: string;

  constructor(
    protected http: HttpClient,
  ) {
    this.server = environment.serverUrl;
  }

  registrarPedido(pedido: Pedido){
    var url = this.server + '/v1/pedido/';
    return this.http.post<Pedido>(url, pedido);
  }
}
