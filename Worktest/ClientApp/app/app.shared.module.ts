import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { ProdIngredientUnitComponent } from './components/fetchdata/prodingredientunit.component';
import { IngredientInventoryComponent } from './components/fetchdata/IngredientInventory.component';
import { ProdIngredientUnitService } from './services/prodingredientunit.service';
import { IngredientInventoryService } from './services/ingredientinventory.service';
import { ProductService } from './services/product.servie';
import { IngredientService } from './services/ingredient.service';



@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,     
        HomeComponent,
        ProdIngredientUnitComponent,
        IngredientInventoryComponent 
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        BrowserModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },      
            { path: 'prod-ingredient-unit', component: ProdIngredientUnitComponent },
            { path: 'ingredients-inventory', component: IngredientInventoryComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ],
    providers: [
        ProdIngredientUnitService,
        IngredientInventoryService,
        ProductService,
        IngredientService
    ]

})
export class AppModuleShared {
}
