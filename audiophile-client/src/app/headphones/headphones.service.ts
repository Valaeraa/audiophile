import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IProduct } from '../shared/models/product';

@Injectable({
  providedIn: 'root',
})
export class HeadphonesService {
  constructor(private http: HttpClient) {}

  getHeadphones(): Observable<IProduct[]> {
    return this.http.get<IProduct[]>(
      'https://localhost:5001/api/products/headphones'
    );
  }

  GetHeadphonesById(id: number): Observable<IProduct> {
    return this.http.get<IProduct>('https://localhost:5001/api/products/' + id);
  }
}
