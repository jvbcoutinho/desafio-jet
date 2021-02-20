import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CestaDeComprasComponent } from './cesta-de-compras.component';
import { MatTableModule } from '@angular/material/table';
import { RouterModule, Routes } from '@angular/router';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';


const routes: Routes = [
  {
    path: '',
    component: CestaDeComprasComponent,
    pathMatch: "full"
  }
];


@NgModule({
  declarations: [CestaDeComprasComponent],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),

    MatTableModule,
    MatIconModule,
    MatButtonModule
  ]
})
export class CestaDeComprasModule { }
