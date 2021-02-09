import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';

import { Observable } from 'rxjs';
import { PropertyType } from './propertyType';
import{ GlobalConstants } from './app.config';

@Injectable({
  providedIn: 'root'
})
export class PropertyTypeService {
  url = GlobalConstants.apiURL + '/PropertyType';
  constructor(private http: HttpClient) { }
  getAllPropertyTypes(): Observable<PropertyType[]> {
    return this.http.get<PropertyType[]>(this.url + '/GetPropertyTypes');
  }
}
