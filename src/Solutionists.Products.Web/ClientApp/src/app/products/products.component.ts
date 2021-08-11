import { Component, Inject, OnInit } from '@angular/core';
import { Product } from '../core/models/product';
import { ProductService } from '../core/api/product.service';

@Component({
  selector: 'app-products-data',
  templateUrl: './products.component.html'
})
export class ProductsComponent implements OnInit {
  public products: Product[];
  public productService: ProductService;

  constructor(productsService: ProductService) {
    this.productService = productsService;
  }

  ngOnInit(): void {
    this.productService.getProducts()
    .subscribe(result => {
      this.products = result;
    }, error => console.error(error));
  }
}
