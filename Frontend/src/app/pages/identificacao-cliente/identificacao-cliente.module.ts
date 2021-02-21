import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IdentificacaoClienteComponent } from './identificacao-cliente.component';
import { RouterModule, Routes } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';


const routes: Routes = [
  {
    path: '',
    component: IdentificacaoClienteComponent,
    pathMatch: "full"
  }
];


@NgModule({
  declarations: [IdentificacaoClienteComponent],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),

    ReactiveFormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule
  ]
})
export class IdentificacaoClienteModule { }
