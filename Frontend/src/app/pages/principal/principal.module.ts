import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PrincipalComponent } from './principal.component';
import { RouterModule, Routes } from '@angular/router';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { ProdutoCardComponent } from './components/produto-card/produto-card.component';


const routes: Routes = [
  {
    path: '',
    component: PrincipalComponent,
    pathMatch: "full"
  }
];

@NgModule({
  declarations: [PrincipalComponent, ProdutoCardComponent],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),

    MatCardModule,
    MatButtonModule
  ]
})
export class PrincipalModule { }
