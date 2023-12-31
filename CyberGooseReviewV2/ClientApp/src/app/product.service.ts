import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private url: string = 'https://localhost:7176/';

  constructor(private http: HttpClient) {
  }

  getProducts<T>() {
    return this.http.get<T[]>(this.url + 'products');
  }

  getProduct<T>(id: number) {
    return this.http.get<T>(this.url + 'product/' + id);
  }
}
