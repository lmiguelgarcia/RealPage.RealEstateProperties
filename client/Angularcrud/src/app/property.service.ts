import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';

import { Observable } from 'rxjs';
import { Property } from './property';
import{ GlobalConstants } from './app.config';

@Injectable({
  providedIn: 'root'
})
export class PropertyService {
  url = GlobalConstants.apiURL + '/Property';

  constructor(private http: HttpClient) { }
  getAllProperties(): Observable<Property[]> {
    return this.http.get<Property[]>(this.url + '/GetProperties');
  }

  getPropertyById(propertyId: string): Observable<Property> {
    return this.http.get<Property>(this.url + '/GetPropertyById?id=' + propertyId);
  }
  createProperty(property: Property): Observable<number> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.post<number>(this.url + '/AddProperty/', property, httpOptions);
  }

  updateProperty(property: Property): Observable<number> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.put<number>(this.url + '/UpdateProperty/', property, httpOptions);
  }

  deletePropertyById(propertyId: string): Observable<number> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.delete<number>(this.url + '/RemoveProperty?id=' + propertyId, httpOptions);
  }

}
