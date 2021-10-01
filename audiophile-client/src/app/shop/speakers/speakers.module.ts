import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SpeakersComponent } from './speakers.component';
import { SpeakersRoutingModule } from './speakers-routing.module';
import { SharedModule } from 'src/app/shared/shared.module';

@NgModule({
  declarations: [SpeakersComponent],
  imports: [CommonModule, SpeakersRoutingModule, SharedModule],
})
export class SpeakersModule {}
