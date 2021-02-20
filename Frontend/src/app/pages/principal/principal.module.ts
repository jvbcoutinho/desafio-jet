import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PrincipalComponent } from './principal.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    component: PrincipalComponent,
    pathMatch: "full"
  }
];

@NgModule({
  declarations: [PrincipalComponent],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})
export class PrincipalModule { }
