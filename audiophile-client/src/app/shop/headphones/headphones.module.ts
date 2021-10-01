import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeadphonesRoutingModule } from './headphones-routing.module';
import { SharedModule } from 'src/app/shared/shared.module';
import { HeadphonesComponent } from './headphones.component';

@NgModule({
  declarations: [HeadphonesComponent],
  imports: [CommonModule, HeadphonesRoutingModule, SharedModule],
})
export class HeadphonesModule {}
