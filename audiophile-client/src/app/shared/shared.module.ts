import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CategoriesComponent } from './categories/categories.component';
import { AboutComponent } from './about/about.component';
import { ProductComponent } from './product/product.component';
import { ProductDetailsComponent } from './product-details/product-details.component';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    CategoriesComponent,
    AboutComponent,
    ProductComponent,
    ProductDetailsComponent,
  ],
  imports: [CommonModule, RouterModule],
  exports: [
    CategoriesComponent,
    AboutComponent,
    ProductComponent,
    ProductDetailsComponent,
  ],
})
export class SharedModule {}
