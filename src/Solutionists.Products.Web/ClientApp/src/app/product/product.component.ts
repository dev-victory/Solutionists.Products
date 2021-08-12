import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ProductService } from '../core/api/product.service';
import { Product } from '../core/models/product';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html'
})
export class ProductComponent implements OnInit {
  public productService: ProductService;
  public product: Product;

  constructor(
    productService: ProductService,
    private route: ActivatedRoute) {
    this.productService = productService;
  }

  ngOnInit() {
    this.productService.getProductById(this.route.snapshot.params.id)
      .subscribe(result => {
        this.product = result;
      },
        error => {
          console.log(error);
        })
  }
}
