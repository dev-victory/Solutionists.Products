import { Component, OnInit } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { Product } from '../core/models/product';
import { ProductService } from '../core/api/product.service';
import { NgxSpinnerService } from 'ngx-spinner';

@Component({
  selector: 'app-products-data',
  templateUrl: './products.component.html'
})
export class ProductsComponent implements OnInit {
  public products: Product[];
  public productService: ProductService;

  constructor(productsService: ProductService,
    private spinner: NgxSpinnerService) {
    this.productService = productsService;
  }

  ngOnInit(): void {
    this.spinner.show();

    this.productService.getProducts()
      .pipe(finalize(() => this.spinner.hide()))
      .subscribe(result => {
        this.products = result;
      }, error => console.error(error));
  }
}
