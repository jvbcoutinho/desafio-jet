import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BehaviorSubject } from 'rxjs';
import { CestaDeComprasService } from 'src/app/services/cesta-de-compras.service';
import { PedidoItem } from 'src/app/shared/models/pedido-item';

@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.scss']
})
export class ToolbarComponent implements OnInit {

  $cestaDeCompras: BehaviorSubject<PedidoItem[]>;

  constructor(
    private cestaDeComprasService: CestaDeComprasService,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.$cestaDeCompras = this.cestaDeComprasService.$cestaDeCompras;
  }

  navigateTo(route: string){
    this.router.navigate([route]);
  }
}
