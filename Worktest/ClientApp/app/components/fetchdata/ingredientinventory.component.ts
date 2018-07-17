import { Component, OnInit } from '@angular/core';
import { Http, RequestOptions } from '@angular/http';
import { IIngredientInventory, IIngredientUnit } from '../../Model/IIngredientInventory';

import { IngredientInventoryService } from '../../services/ingredientinventory.service';
import { IngredientService } from '../../services/ingredient.service';



@Component({
    moduleId: module.id.toString(),
    selector: 'IngredientInventory',
    templateUrl: './ingredientinventory.component.html'
})
export class IngredientInventoryComponent implements OnInit {

    public ingredientInventories: IIngredientInventory[];

    public showAddFields: boolean = false;
    public ingredientPost: IIngredientUnit = {
        ingredientName: "",
        unit: 0
    };



    constructor(private readonly _ingredientInventoryService: IngredientInventoryService,
        private readonly _ingredientService: IngredientService) {
  
    }

    ngOnInit() {

        this._ingredientInventoryService.GetIngredientInventory()
            .subscribe(result => {
                this.ingredientInventories = result.json() as IIngredientInventory[];
            }, error => console.error(error));


    }

    ShowAddField() {
        this.showAddFields = true;
    }

    CancelField() {
        this.showAddFields = false;
    }

    Submit() {      
        this._ingredientInventoryService.SaveIngredientUnit(this.ingredientPost)
            .subscribe(result => {                
                let x = result.json() as boolean;
                if (x) {
                    this.showAddFields = false;
                    this.clear();
                }
            },
            error => console.error(error));
    }

    clear() {
        this.ingredientPost.ingredientName = "";
        this.ingredientPost.unit = 0;
    }

}