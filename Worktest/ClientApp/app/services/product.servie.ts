import { Injectable, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Injectable()
export class ProductService {

    private readonly _apiUrl = 'api/products';
    private _baseUrl = ''

    constructor(private http: Http, @Inject('BASE_URL') baseUrl: string) {
        this._baseUrl = baseUrl;
    }

    GetProducts() {
        return this.http
            .get(this._baseUrl + this._apiUrl);
    }


}
