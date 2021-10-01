import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EarphonesRoutingModule } from './earphones-routing.module';
import { EarphonesComponent } from './earphones.component';
import { SharedModule } from 'src/app/shared/shared.module';

@NgModule({
  declarations: [EarphonesComponent],
  imports: [CommonModule, EarphonesRoutingModule, SharedModule],
})
export class EarphonesModule {}
