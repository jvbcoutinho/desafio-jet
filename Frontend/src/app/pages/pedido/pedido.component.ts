import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, Router } from '@angular/router';
import { PedidoHttpService } from 'src/app/core/http/produto/pedido-http.service';
import { Pedido } from 'src/app/shared/models/pedido';
import { PedidoItem } from 'src/app/shared/models/pedido-item';

@Component({
  selector: 'app-pedido',
  templateUrl: './pedido.component.html',
  styleUrls: ['./pedido.component.scss']
})
export class PedidoComponent implements OnInit {

  pedido: Pedido;
  dataSource = new MatTableDataSource<PedidoItem>();
  displayedColumns: string[] = ['nome', 'valorUnitario', 'quantidade', 'subtotal'];

  constructor(
    private pedidoHttpService: PedidoHttpService,
    private route: ActivatedRoute
  ) { }

  ngOnInit(): void {
    let id = this.route.snapshot.params['id'];
    this.pedidoHttpService.obterPorId(id).subscribe(p =>{
      this.pedido = p;
      this.dataSource.data = p.itens
    });
  }

  obterTotal(){
    return this.dataSource.data.reduce((acc, p) => acc + (p.quantidade * p.valorUnitario), 0);
  }

}
