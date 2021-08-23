import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from "@angular/forms";
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

import { AppComponent } from './app.component';
import { CustomerDetailsComponent } from './customer-details/customer-details.component';
import { CustomerDetailFormComponent } from './customer-details/customer-detail-form/customer-detail-form.component';
//import { CustomerDetailComponent } from './shared/customer-detail/customer-detail.component';
//import { CustomerDetailModel } from './shared/customer-detail/customer-detail.model';

@NgModule({
  declarations: [
    AppComponent,
    CustomerDetailsComponent,
    CustomerDetailFormComponent,
    //CustomerDetailComponent,
    //cd CustomerDetailModel
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
