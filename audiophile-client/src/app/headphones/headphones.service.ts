import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { IProduct } from '../shared/models/product';

@Injectable({
  providedIn: 'root',
})
export class HeadphonesService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  getHeadphones(): Observable<IProduct[]> {
    return this.http.get<IProduct[]>(
      `${this.baseUrl}/products?category=headphones`
    );
  }

  GetHeadphonesById(id: number): Observable<IProduct> {
    return this.http.get<IProduct>(`${this.baseUrl}/products/${id}`);
  }
}
