import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PrincipalComponent } from './principal.component';
import { RouterModule, Routes } from '@angular/router';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { ProdutoCardComponent } from './components/produto-card/produto-card.component';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';


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
    MatButtonModule,
    MatProgressSpinnerModule
  ]
})
export class PrincipalModule { }
