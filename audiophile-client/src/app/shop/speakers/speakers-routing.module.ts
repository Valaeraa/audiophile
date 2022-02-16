import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { SpeakersComponent } from './speakers.component';
import { ProductDetailsComponent } from 'src/app/shared/product-details/product-details.component';

const routes: Routes = [
  { path: '', component: SpeakersComponent },
  { path: ':slug', component: ProductDetailsComponent },
];

@NgModule({
  declarations: [],
  imports: [CommonModule, RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class SpeakersRoutingModule {}
