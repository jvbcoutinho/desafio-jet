import { Component, Input, OnInit } from '@angular/core';
import { CestaDeComprasService } from 'src/app/services/cesta-de-compras.service';
import { Produto } from 'src/app/shared/models/produto';

@Component({
  selector: 'app-produto-card',
  templateUrl: './produto-card.component.html',
  styleUrls: ['./produto-card.component.scss']
})
export class ProdutoCardComponent implements OnInit {

  @Input() produto: Produto;

  constructor(
    private cestaDeComprasService: CestaDeComprasService
  ) { }

  ngOnInit(): void {
  }

  clickAdicionar(){
    this.cestaDeComprasService.adicionarProduto(this.produto, 1);
  }

}
