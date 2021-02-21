import { Component, OnInit } from '@angular/core';
import { ProdutoHttpService } from 'src/app/core/http/produto/produto-http.service';
import { Produto } from 'src/app/shared/models/produto';

@Component({
  selector: 'app-principal',
  templateUrl: './principal.component.html',
  styleUrls: ['./principal.component.scss']
})
export class PrincipalComponent implements OnInit {

  produtos: Produto[];

  constructor(
    private produtoService: ProdutoHttpService,
  ) { }

  ngOnInit(): void {
    this.produtoService.obterTodos().subscribe( response => {
      this.produtos = response;
    })
  }

}
