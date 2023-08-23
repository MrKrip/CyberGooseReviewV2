import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Product } from '../product';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.css']
})
export class ProductDetailsComponent implements OnInit {
  title = "Product";
  public product!: Product;
  public Loader: boolean = true;
  public HasYTLink: boolean = false;
  private id: number;

  constructor(private productService: ProductService, activeRoute: ActivatedRoute) {
    this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
  }

  ngOnInit() {
    if (this.id) {
      this.productService.getProduct<Product>(this.id)
        .subscribe((data: Product) => { this.product = data; this.Loader = false });
    }
  }
}
