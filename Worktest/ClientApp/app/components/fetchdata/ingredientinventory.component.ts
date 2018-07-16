import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { IngredientInventoryService } from '../../services/ingredientinventory.service';
import { IIngredientInventory } from '../../Model/IIngredientInventory';


@Component({
    moduleId: module.id.toString(),
    selector: 'IngredientInventory',
    templateUrl: './ingredientinventory.component.html'
})
export class IngredientInventoryComponent implements OnInit {

    public IngredientInventories: IIngredientInventory[];

    constructor(private _ingredientInventoryService: IngredientInventoryService) {  }

    ngOnInit() {        
        this._ingredientInventoryService.GetIngredientInventory()
            .subscribe(result => {
                this.IngredientInventories = result.json() as IIngredientInventory[];
        }, error => console.error(error));
    }
}