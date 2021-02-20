import { Component, OnInit } from '@angular/core';
import { ProdutoService } from 'src/app/core/http/produto/produto.service';
import { Produto } from 'src/app/shared/models/produto';

@Component({
  selector: 'app-principal',
  templateUrl: './principal.component.html',
  styleUrls: ['./principal.component.scss']
})
export class PrincipalComponent implements OnInit {

  produtos: Produto[];

  constructor(
    private produtoService: ProdutoService,
  ) { }

  ngOnInit(): void {
    this.produtoService.obterProdutos().subscribe( response => {
      this.produtos = response;
    })
  }

}
