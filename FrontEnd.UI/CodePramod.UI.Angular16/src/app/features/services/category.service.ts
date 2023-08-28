import { Injectable } from '@angular/core';
import { AddCategoryRequest } from '../models/add-category-request.models';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root' //Availble throught application 
})
export class CategoryService {

  constructor(private http : HttpClient) { }

  AddCategory(model : AddCategoryRequest) : Observable<void>  {

    console.log("From category service : "+JSON.stringify(model));
    return this.http.post<void>('https://localhost:7127/api/categories',model);
    
  }
}
