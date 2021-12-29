import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { IProduct } from '../shared/models/product';

@Injectable({
  providedIn: 'root',
})
export class ShopService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  // TODO - Separate getProducts by category and all
  getProducts(category = ''): Observable<IProduct[]> {
    return this.http.get<IProduct[]>(
      `${this.baseUrl}/products?category=${category}`
    );
  }

  getProductById(id: number): Observable<IProduct> {
    return this.http.get<IProduct>(`${this.baseUrl}/products/${id}`);
  }

  getProductBySlug(slug: string): Observable<IProduct> {
    return this.http.get<IProduct>(`${this.baseUrl}/products/${slug}`);
  }
}
