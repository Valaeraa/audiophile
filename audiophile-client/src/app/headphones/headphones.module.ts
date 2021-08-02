import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeadphonesComponent } from './headphones.component';
import { SharedModule } from '../shared/shared.module';
import { HeadphonesRoutingModule } from './headphones-routing.module';

@NgModule({
  declarations: [HeadphonesComponent],
  imports: [CommonModule, SharedModule, HeadphonesRoutingModule],
})
export class HeadphonesModule {}
