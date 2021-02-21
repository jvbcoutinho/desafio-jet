import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { Router } from '@angular/router';
import { CestaDeComprasService } from 'src/app/services/cesta-de-compras.service';
import { PedidoItem } from 'src/app/shared/models/pedido-item';

@Component({
  selector: 'app-cesta-de-compras',
  templateUrl: './cesta-de-compras.component.html',
  styleUrls: ['./cesta-de-compras.component.scss']
})
export class CestaDeComprasComponent implements OnInit {

  dataSource = new MatTableDataSource<PedidoItem>();
  displayedColumns: string[] = ['nome', 'valorUnitario', 'quantidade', 'subtotal'];

  constructor(
    private cestaDeComprasService: CestaDeComprasService,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.cestaDeComprasService.$cestaDeCompras.subscribe(cesta =>
      this.dataSource.data = cesta
    )
  }

  adicionarUnidades(produtoId: string, quantidade: number){
    this.cestaDeComprasService.alterarUnidades(produtoId, quantidade);
  }

  navigateTo(route: string){
    this.router.navigate([route]);
  }

  obterTotal(){
    return this.dataSource.data.reduce((acc, p) => acc + (p.quantidade * p.valorUnitario), 0);
  }
}
