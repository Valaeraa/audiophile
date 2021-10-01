import { Component, OnInit } from '@angular/core';
import { IProduct } from 'src/app/shared/models/product';
import { ShopService } from '../shop.service';

@Component({
  selector: 'app-earphones',
  templateUrl: './earphones.component.html',
  styleUrls: ['./earphones.component.scss'],
})
export class EarphonesComponent implements OnInit {
  products: IProduct[] = [];

  constructor(private shopService: ShopService) {}

  ngOnInit(): void {
    this.getEarphones();
  }

  getEarphones(): void {
    this.shopService.getProducts('earphones').subscribe(
      (response) => {
        this.products = response;
        this.products.map((p) => {
          if (p.name === 'YX1 Wireless Earphones') {
            p.display = {
              mobile:
                '/assets/category-earphones/mobile/image-yx1-earphones.jpg',
              tablet:
                '/assets/category-earphones/tablet/image-yx1-earphones.jpg',
              desktop:
                '/assets/category-earphones/desktop/image-yx1-earphones.jpg',
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
