import { Component, OnDestroy } from '@angular/core';
import { AddCategoryRequest } from '../../models/add-category-request.models';
import { CategoryService } from '../../services/category.service';
import { Subscription } from 'rxjs';


@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrls: ['./add-category.component.css']
})
export class AddCategoryComponent implements OnDestroy {
  model: AddCategoryRequest;
  private addCategorySubscription?: Subscription;
  constructor(private categoryService: CategoryService) {
    this.model = {
      name: 'Pramod1',
      urlHandle: 'urlHAndle111'
    };
  }
  onFormSubmit() {
    console.log(this.model);
    this.categoryService.AddCategory(this.model)
    .subscribe({
      next:(response)=>{
        console.log(' Response-Success from Category Service   : ' + response);
      },
      error:(error)=>{
        console.log(' Response-Failure from Category Service   : ' + error);
      }
    })
  }

ngOnDestroy():void{
this.addCategorySubscription?.unsubscribe();
}

}
