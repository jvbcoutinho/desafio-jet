import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { PedidoItem } from '../shared/models/pedido-item';
import { Produto } from '../shared/models/produto';

@Injectable({
  providedIn: 'root'
})
export class CestaDeComprasService {

  $cestaDeCompras = new BehaviorSubject<PedidoItem[]>([]);

  constructor() { }

  adicionarProduto(produto: Produto, unidades: number) {
    var produtoPresenteNaCesta = this.$cestaDeCompras.value.find(x => x.produtoId == produto.id);

    if (produtoPresenteNaCesta)
      produtoPresenteNaCesta.quantidade += unidades;
    else
      this.adicionarNovoItem(produto, unidades);
  }

  alterarUnidades(produtoId: string, unidades: number) {
    var produto = this.$cestaDeCompras.value.find(x => x.produtoId == produtoId);

    if(produto.quantidade <= 0 && unidades < 0)
      return;

    produto.quantidade += unidades;

    this.$cestaDeCompras.next(this.$cestaDeCompras.value);
  }

  private adicionarNovoItem(produto: Produto, unidades: number) {
    var pedidoItem: PedidoItem = {
      produtoId: produto.id,
      produtoNome: produto.nome,
      quantidade: unidades,
      valorUnitario: produto.preco
    }

    this.$cestaDeCompras.next([...this.$cestaDeCompras.value, pedidoItem])
  }
}
