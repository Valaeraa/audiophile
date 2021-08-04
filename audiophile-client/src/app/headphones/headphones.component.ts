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
        console.log(this.products);
      },
      (error) => {
        console.log(error);
      }
    );
  }
}
