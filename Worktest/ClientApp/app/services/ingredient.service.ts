import { Injectable, Inject } from '@angular/core';
import { Http } from '@angular/http';


@Injectable()
export class IngredientService {

    private readonly _apiUrl = 'api/ingredients';
    private _baseUrl = ''

    constructor(private http: Http, @Inject('BASE_URL') baseUrl: string) {
        this._baseUrl = baseUrl;
    }

    GetIngredients() {
        return this.http
            .get(this._baseUrl + this._apiUrl);
    }


}
