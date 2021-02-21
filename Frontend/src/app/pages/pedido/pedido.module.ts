import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { MatTableModule } from '@angular/material/table';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { MatButtonModule } from '@angular/material/button';
import { PedidoComponent } from './pedido.component';

const routes: Routes = [
  {
    path: '',
    component: PedidoComponent,
    pathMatch: "full"
  }
];

@NgModule({
  declarations: [PedidoComponent],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),

    MatTableModule,
    MatIconModule,
    MatButtonModule,
    MatListModule
  ]
})
export class PedidoModule { }
