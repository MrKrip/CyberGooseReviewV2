import { Component, OnInit, SecurityContext } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
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
  public console = console;

  constructor(private productService: ProductService, activeRoute: ActivatedRoute, private sanitizer: DomSanitizer) {
    this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
  }

  ngOnInit() {
    if (this.id) {
      this.productService.getProduct<Product>(this.id)
        .subscribe((data: Product) => {
          this.product = data;
          this.Loader = false;
          if (this.product.youTubeLink) {
            this.product.youTubeLink = this.sanitizer.sanitize(SecurityContext.RESOURCE_URL, this.sanitizer.bypassSecurityTrustResourceUrl(this.product.youTubeLink));
          }          
        });
    }
  }
}
