import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';

import { Observable } from 'rxjs';
import { PropertyType } from './propertyType';


@Injectable({
  providedIn: 'root'
})
export class PropertyTypeService {
  url = 'http://localhost:54433/api/v1/PropertyType';
  constructor(private http: HttpClient) { }
  getAllPropertyTypes(): Observable<PropertyType[]> {
    return this.http.get<PropertyType[]>(this.url + '/GetPropertyTypes');
  }
}
