import { Routes } from '@angular/router';
import { ProductComponent } from './product/product.component';
import { ProductsComponent } from './products/products.component';

export const ROUTES: Routes = [
  { path: '', component: ProductsComponent },
  { path: 'products', component: ProductsComponent},
  { path: 'products/:id', component: ProductComponent }
];
