import { Component, OnInit } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { ActivatedRoute } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
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
    private spinner: NgxSpinnerService,
    private route: ActivatedRoute) {
    this.productService = productService;
  }

  ngOnInit() {
    this.spinner.show();
    this.productService.getProductById(this.route.snapshot.params.id)
      .pipe(finalize(() => this.spinner.hide()))
      .subscribe(result => {
        this.product = result;
        this.spinner.hide();
      },
        error => console.log(error))
  }
}
