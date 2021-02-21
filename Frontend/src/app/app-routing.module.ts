import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    loadChildren: () => import('./pages/principal/principal.module').then((m) => m.PrincipalModule),
  },
  {
    path: 'cesta-de-compras',
    loadChildren: () => import('./pages/cesta-de-compras/cesta-de-compras.module').then((m) => m.CestaDeComprasModule),
  },
  {
    path: 'identificacao',
    loadChildren: () => import('./pages/identificacao-cliente/identificacao-cliente.module').then((m) => m.IdentificacaoClienteModule),
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
