import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ShopService } from 'src/app/shop/shop.service';
import { IProduct } from '../models/product';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.scss'],
})
export class ProductDetailsComponent implements OnInit {
  product!: IProduct;

  constructor(
    private shopService: ShopService,
    private activatedRoute: ActivatedRoute,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.loadProduct();
  }

  // loadProduct(): void {
  //   const id = this.activatedRoute.snapshot.paramMap
  //     .get('id-slug')
  //     ?.slice(0, 1) as string;

  //   const idValue = +id;
  //   this.shopService.getProductById(idValue).subscribe(
  //     (product) => {
  //       this.product = product;
  //     },
  //     (error) => {
  //       console.log(error);
  //     }
  //   );
  // }

  loadProduct(): void {
    const slug = this.activatedRoute.snapshot.paramMap.get('slug') as string;

    this.shopService.getProductBySlug(slug).subscribe(
      (product) => {
        this.product = product;
      },
      (error) => {
        console.log(error);
      }
    );
  }

  btnOtherProduct(slug: string) {
    let category: string = slug.split('-').slice(-1).toString();

    if (category === 'speaker') {
      category = 'speakers';
    }

    this.router.navigateByUrl('/', { skipLocationChange: true }).then(() => {
      this.router.navigateByUrl(`/${category}/${slug}`);
    });
  }
}
