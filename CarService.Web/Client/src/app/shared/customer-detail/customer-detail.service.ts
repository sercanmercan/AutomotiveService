import { Injectable } from '@angular/core';
import { Customer } from './customer-detail.model';
import { HttpClient } from "@angular/common/http";
@Injectable({
  providedIn: 'root'
})

export class CustomerDetailService {
  constructor(private http: HttpClient) { }
  readonly baseURL = 'http://localhost:44306/api/Customer';
  formData: Customer = new Customer();
  list: Customer[];

  CreateCustomer() {
    return this.http.post(this.baseURL, this.formData);
  }

  UpdateCustomer() {
    return this.http.put(`${this.baseURL}/${this.formData.Id}`, this.formData);
  }

  DeleteCustomer(Id : number) {
    return this.http.delete(`${this.baseURL}/${Id}`);
  }

  refreshList() {
    this.http.get(this.baseURL).toPromise().then(res => this.list = res as Customer[]);
  }
}
