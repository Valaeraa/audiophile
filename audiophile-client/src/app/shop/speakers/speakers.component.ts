import { Component, OnInit } from '@angular/core';
import { IProduct } from 'src/app/shared/models/product';
import { ShopService } from '../shop.service';

@Component({
  selector: 'app-speakers',
  templateUrl: './speakers.component.html',
  styleUrls: ['./speakers.component.scss'],
})
export class SpeakersComponent implements OnInit {
  products: IProduct[] = [];

  constructor(private shopService: ShopService) {}

  ngOnInit(): void {
    this.getSpeakers();
  }

  getSpeakers(): void {
    this.shopService.getProducts('speakers').subscribe(
      (response) => {
        this.products = response;
        this.products.map((p) => {
          if (p.name === 'ZX9 Speaker') {
            p.display = {
              mobile: '/assets/category-speakers/mobile/image-zx9.jpg',
              tablet: '/assets/category-speakers/tablet/image-zx9.jpg',
              desktop: '/assets/category-speakers/desktop/image-zx9.jpg',
            };
          }

          if (p.name === 'ZX7 Speaker') {
            p.display = {
              mobile: '/assets/category-speakers/mobile/image-zx7.jpg',
              tablet: '/assets/category-speakers/tablet/image-zx7.jpg',
              desktop: '/assets/category-speakers/desktop/image-zx7.jpg',
            };
          }
        });
      },
      (error) => {
        console.log(error);
      }
    );
  }
}
