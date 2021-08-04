import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HeadphonesService } from 'src/app/headphones/headphones.service';
import { IProduct } from '../models/product';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.scss'],
})
export class ProductDetailsComponent implements OnInit {
  product!: IProduct;

  constructor(
    private headphonesService: HeadphonesService,
    private activatedRoute: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.loadProduct();
    console.log(this.product);
  }

  loadProduct(): void {
    const id = this.activatedRoute.snapshot.paramMap.get('id') as string;
    const idValue = +id;
    this.headphonesService.GetHeadphonesById(idValue).subscribe(
      (product) => {
        this.product = product;
      },
      (error) => {
        console.log(error);
      }
    );
  }
}
