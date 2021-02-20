import { Component, Input, OnInit } from '@angular/core';
import { Produto } from 'src/app/shared/models/produto';

@Component({
  selector: 'app-produto-card',
  templateUrl: './produto-card.component.html',
  styleUrls: ['./produto-card.component.scss']
})
export class ProdutoCardComponent implements OnInit {

  @Input() produto: Produto;

  constructor() { }

  ngOnInit(): void {
  }

}
