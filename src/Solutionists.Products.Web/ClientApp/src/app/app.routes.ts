import { Routes } from '@angular/router';
import { ProductsComponent } from './products/products.component';

export const ROUTES: Routes = [
  { path: '', component: ProductsComponent, pathMatch: 'full' }
];