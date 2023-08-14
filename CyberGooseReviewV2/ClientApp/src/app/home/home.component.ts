import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Product } from '../product';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  title = "Home Page";
  public Products: Product[] = [];

  constructor(http: HttpClient) {
    http.get<Product[]>('https://localhost:7176/Home').subscribe(result => {
      this.Products = result;
    }, error => console.error(error));
  }

}
