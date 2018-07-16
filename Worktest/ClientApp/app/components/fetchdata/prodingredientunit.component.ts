import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { ProdIngredientUnitService } from '../../services/prodingredientunit.service';
import { IProdIngredientUnit } from '../../Model/IProdIngredientUnit';


@Component({
    moduleId: module.id.toString(),
    selector: 'prodIngredientUnit',
    templateUrl: './prodingredientunit.component.html'
})
export class ProdIngredientUnitComponent implements OnInit {

    public prodIngredients: IProdIngredientUnit[];

    constructor(private _prodIngredientUnitService: ProdIngredientUnitService) {  }

    ngOnInit() {        
        this._prodIngredientUnitService.getProdIngredientUnits()
            .subscribe(result => {
                this.prodIngredients = result.json() as IProdIngredientUnit[];
        }, error => console.error(error));
    }
}