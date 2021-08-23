//import { Component } from '@angular/core';

//@Component({
//  selector: 'app-customer-detail',
//  templateUrl: './customer-detail.model.html',
//  styleUrls: ['./customer-detail.model.css']
//})
//export class CustomerDetailModel implements OnInit {

//  //constructor() { }

//  //ngOnInit(): void {
//  //}
//  Id: number;
//}

export class Customer {
  constructor() {
    this.Id = 0;
    this.name = '';
    this.surname = '';
    this.tcNo = '';
    this.telNo = '';
    this.email = '';
  
  }
  Id: number;
  name: string;
  surname: string;
  tcNo: string;
  telNo: string;
  email: string;
}
