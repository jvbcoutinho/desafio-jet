import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { PedidoHttpService } from 'src/app/core/http/produto/pedido-http.service';
import { CestaDeComprasService } from 'src/app/services/cesta-de-compras.service';
import { Cliente } from 'src/app/shared/models/cliente';
import { Pedido } from 'src/app/shared/models/pedido';
import { PedidoItem } from 'src/app/shared/models/pedido-item';

@Component({
  selector: 'app-identificacao-cliente',
  templateUrl: './identificacao-cliente.component.html',
  styleUrls: ['./identificacao-cliente.component.scss']
})
export class IdentificacaoClienteComponent implements OnInit {

  public cliente: FormGroup;

  constructor(
    private pedidoHttpService: PedidoHttpService,
    private cestaDeComprasService: CestaDeComprasService,
  ) { }

  ngOnInit(): void {
    this.cliente = new FormGroup({
      nome: new FormControl(null, Validators.required),
      email: new FormControl(null, [Validators.required, Validators.email]),
      telefone: new FormControl(null, Validators.required),
    });
  }

  registrarPedido() {
    var cliente: Cliente = this.cliente.value;
    var pedidoItens: PedidoItem[] = this.cestaDeComprasService.$cestaDeCompras.value;

    var pedido: Pedido = {
      nome: cliente.nome,
      email: cliente.nome,
      telefone: cliente.telefone,
      itens: pedidoItens,
    };

    this.pedidoHttpService.registrarPedido(pedido).subscribe(result => {
      console.log(result);
    })
  }

}
