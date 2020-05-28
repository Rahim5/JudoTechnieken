import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {FormsModule} from "@angular/forms";

import { AppComponent } from './app.component';
import { JudoServiceService } from './judo-service.service';


@NgModule({
  declarations: [
    AppComponent,
  
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule
   
   
  ],
  providers: [
    JudoServiceService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
