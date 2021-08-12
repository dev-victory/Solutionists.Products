import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from '../models/product';

@Injectable()
export class ProductService {
    public httpClient: HttpClient;
    public baseUrl: string;

    constructor(httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.httpClient = httpClient;
        // TODO: revert to baseurl
        this.baseUrl = 'https://localhost:44347/'; //baseUrl;
    }

    public getProducts(): Observable<Product[]> {
        return this.httpClient.get<Product[]>( this.baseUrl + 'products');
    }

    public getProductById(id: string): Observable<Product> {
        return this.httpClient.get<Product>(`${this.baseUrl}products/${id}`);
    }
}