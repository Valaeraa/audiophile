import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CategoriesComponent } from './categories/categories.component';
import { AboutComponent } from './about/about.component';

@NgModule({
  declarations: [CategoriesComponent, AboutComponent],
  imports: [CommonModule],
  exports: [CategoriesComponent, AboutComponent],
})
export class SharedModule {}
