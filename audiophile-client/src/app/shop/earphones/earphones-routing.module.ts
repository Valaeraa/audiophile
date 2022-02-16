import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { EarphonesComponent } from './earphones.component';
import { ProductDetailsComponent } from 'src/app/shared/product-details/product-details.component';

const routes: Routes = [
  { path: '', component: EarphonesComponent },
  { path: ':slug', component: ProductDetailsComponent },
];

@NgModule({
  declarations: [],
  imports: [CommonModule, RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class EarphonesRoutingModule {}
