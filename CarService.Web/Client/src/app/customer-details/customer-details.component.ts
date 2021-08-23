import { Component, OnInit } from '@angular/core';
import { CustomerDetailService } from '../shared/customer-detail/customer-detail.service';
import { Customer } from '../shared/customer-detail/customer-detail.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-customer-details',
  templateUrl: './customer-details.component.html',
  styles: [
  ]
})
export class CustomerDetailsComponent implements OnInit {

  constructor(public service: CustomerDetailService,
    private toastr: ToastrService) { }

  ngOnInit(): void {
    this.service.refreshList();
  }

  populateForm(selectedRecord: Customer) {
    this.service.formData = Object.assign({}, selectedRecord);
  }
  onDelete(Id: number) {
    if (confirm('Are you sure to dlete this record?')) {

    this.service.DeleteCustomer(Id).subscribe(
      res => {
        this.service.refreshList();
        this.toastr.error("Deleted successfully",'Create Customer')
      }, err => { console.log(err) })

    }
  }
}
