import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { HeadphonesComponent } from './headphones.component';
import { ProductComponent } from '../shared/product/product.component';
import { ProductDetailsComponent } from '../shared/product-details/product-details.component';

const routes: Routes = [
  { path: '', component: HeadphonesComponent },
  { path: ':id', component: ProductDetailsComponent },
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class HeadphonesRoutingModule {}
