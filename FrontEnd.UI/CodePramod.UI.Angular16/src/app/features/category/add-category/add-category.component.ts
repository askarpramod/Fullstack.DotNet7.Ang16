import { Component } from '@angular/core';
import { AddCategoryRequest } from '../../models/add-category-request.models';
import { CategoryService } from '../../services/category.service';

@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrls: ['./add-category.component.css']
})
export class AddCategoryComponent {
  model: AddCategoryRequest
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
}
