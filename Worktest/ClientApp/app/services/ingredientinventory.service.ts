import { Injectable, Inject } from '@angular/core';
import { Http, Headers, RequestOptions  } from '@angular/http';
import { IIngredientUnit } from '../Model/IIngredientInventory';



@Injectable()
export class IngredientInventoryService {

    private _baseUrl = ''

    constructor(private http: Http, @Inject('BASE_URL') baseUrl: string) {
        this._baseUrl = baseUrl;
    }

    GetIngredientInventory() {
        return this.http
            .get(this._baseUrl + 'api/ingredient-inventory');
    }

    SaveIngredientUnit(model: IIngredientUnit) {
        debugger

        let body = JSON.stringify(model);
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options: any = new RequestOptions({ headers: headers });
      
     
        return this.http
            .post(this._baseUrl + 'api/save-ingredient', body, options);
    }

}
