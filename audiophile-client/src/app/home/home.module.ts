import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home.component';
import { SharedModule } from '../shared/shared.module';
import { HeadphonesRoutingModule } from '../headphones/headphones-routing.module';

@NgModule({
  declarations: [HomeComponent],
  imports: [CommonModule, SharedModule, HeadphonesRoutingModule],
  exports: [HomeComponent],
})
export class HomeModule {}
