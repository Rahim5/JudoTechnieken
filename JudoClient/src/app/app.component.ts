import { Component } from '@angular/core';
import { JudoServiceService, ITechniek } from './judo-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  
  Naam:string;
  Type:string;
 
  

  constructor(private service: JudoServiceService){
    this.service.GetData().subscribe((result) =>{
      console.log(result);

      this.Naam=result.naam;
      this.Type=result.type;
     
      
    });
  }
}



