import { Component, OnInit } from '@angular/core';
import { IProduct } from '../shared/models/product';
import { HeadphonesService } from './headphones.service';

@Component({
  selector: 'app-headphones',
  templateUrl: './headphones.component.html',
  styleUrls: ['./headphones.component.scss'],
})
export class HeadphonesComponent implements OnInit {
  products!: IProduct[];

  constructor(private headphonesService: HeadphonesService) {}

  ngOnInit(): void {
    this.getHeadphones();
  }

  getHeadphones(): void {
    this.headphonesService.getHeadphones().subscribe(
      (response) => {
        this.products = response;
        this.products.map((p) => {
          if (p.name === 'XX59 Headphones') {
            p.display = {
              mobile: '/assets/category-headphones/mobile/image-xx59.jpg',
              tablet: '/assets/category-headphones/tablet/image-xx59.jpg',
              desktop: '/assets/category-headphones/desktop/image-xx59.jpg',
            };
          }

          if (p.name === 'XX99 Mark I Headphones') {
            p.display = {
              mobile:
                '/assets/category-headphones/mobile/image-xx99-mark-one.jpg',
              tablet:
                '/assets/category-headphones/tablet/image-xx99-mark-one.jpg',
              desktop:
                '/assets/category-headphones/desktop/image-xx99-mark-one.jpg',
            };
          }

          if (p.name === 'XX99 Mark II Headphones') {
            p.display = {
              mobile:
                '/assets/category-headphones/mobile/image-xx99-mark-two.jpg',
              tablet:
                '/assets/category-headphones/tablet/image-xx99-mark-two.jpg',
              desktop:
                '/assets/category-headphones/desktop/image-xx99-mark-two.jpg',
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
