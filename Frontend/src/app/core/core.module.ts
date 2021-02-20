import { NgModule, Optional, SkipSelf } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ToolbarComponent } from './toolbar/toolbar/toolbar.component';

import { MatToolbarModule } from '@angular/material/toolbar';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [ToolbarComponent],
  imports: [
    CommonModule,
    MatToolbarModule,
    HttpClientModule
  ],
  exports:
  [
    ToolbarComponent
  ]
})

export class CoreModule
{
    constructor (@Optional() @SkipSelf() parentModule?: CoreModule) {
      if (parentModule) {
        throw new Error(
          'CoreModule já foi importado. Ele deve ser importado apenas no MainModule!');
      }
    }
}
