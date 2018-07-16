import { Injectable, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { IProdIngredientUnit } from '../Model/IProdIngredientUnit';
import { Observable } from 'rxjs';


@Injectable()
export class IngredientInventoryService {

    private readonly _apiUrl = 'api/IngredientInventory/GetIngredientInventory';
    private _baseUrl = ''

    constructor(private http: Http, @Inject('BASE_URL') baseUrl: string) {
        this._baseUrl = baseUrl;
    }

    GetIngredientInventory() {
        return this.http
            .get(this._baseUrl + this._apiUrl);
    }


}
