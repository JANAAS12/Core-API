import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ServiceService {

  constructor(private http:HttpClient) { }

  getAllCategory() {
    return this.http.get("https://localhost:7060/api/Category");
  }
  getAllProducts() {
    return this.http.get("https://localhost:7060/api/Product");
  }

}
