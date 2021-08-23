import { Component, OnInit } from '@angular/core';
import { CustomerDetailService } from '../../shared/customer-detail/customer-detail.service';
import { NgForm } from '@angular/forms';
import { Customer } from '../../shared/customer-detail/customer-detail.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-customer-detail-form',
  templateUrl: './customer-detail-form.component.html',
  styles: [
  ]
})
export class CustomerDetailFormComponent implements OnInit {

  constructor(public service: CustomerDetailService,
    private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  onSubmit(form: NgForm) {
    if (this.service.formData.Id == 0)
      this.insertRecord(form);
    else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.CreateCustomer().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
        this.toastr.success('Submitted successfully', 'Create Customer')
      },
      err => { console.log(err); }
    );
  }

  updateRecord(form: NgForm) {
    this.service.UpdateCustomer().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
        this.toastr.info('Updated successfully', 'Create Customer')
      },
      err => { console.log(err); }
    );
  }


  resetForm(form: NgForm) {
    form.form.reset();
    this.service.formData = new Customer();
  }
}
