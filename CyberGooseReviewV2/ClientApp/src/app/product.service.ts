import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private url: string = 'https://localhost:7176/';
  private pageSize: number = 10;

  constructor(private http: HttpClient) {
  }

  getProducts<T>() {
    return this.http.get<T[]>(this.url + 'products');
  }
}
