import { NgModule, Optional, SkipSelf } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ToolbarComponent } from './toolbar/toolbar/toolbar.component';

import { MatToolbarModule } from '@angular/material/toolbar';
import { HttpClientModule } from '@angular/common/http';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon'
import { MatBadgeModule } from '@angular/material/badge';

@NgModule({
  declarations: [ToolbarComponent],
  imports: [
    CommonModule,
    HttpClientModule,

    MatToolbarModule,
    MatButtonModule,
    MatIconModule,
    MatBadgeModule
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
