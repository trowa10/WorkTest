import { Injectable, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Injectable()
export class ProdIngredientUnitService { 

    private readonly _apiUrl = 'api/product-ingredient-units';
    private _baseUrl = ''

    constructor(private http: Http, @Inject('BASE_URL') baseUrl: string) {
        this._baseUrl = baseUrl;   
    }

    getProdIngredientUnits() {        
        return this.http
            .get(this._baseUrl + this._apiUrl);  
    }



}
