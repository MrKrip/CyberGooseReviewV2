import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { Product } from '../product';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  title = "Home Page";
  public Products: Product[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Product[]>(baseUrl + 'Home').subscribe(result => {
      this.Products = result;
    }, error => console.error(error));
  }
}
