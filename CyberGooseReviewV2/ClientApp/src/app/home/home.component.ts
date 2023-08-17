import { Component } from '@angular/core';
import { Product } from '../product';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  title = "Home Page";
  public Products: Product[] = [];
  private NumberOfProd: number = 10;
  public Loader: boolean = true;

  constructor(private productService: ProductService) {

  }

  ngOnInit() {
    this.productService.getProducts<Product>().subscribe(result => {
      this.Products = result.reverse().slice(0, this.NumberOfProd);
      this.Loader = false;
    });
  }

}
