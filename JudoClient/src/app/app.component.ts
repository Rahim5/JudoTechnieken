import { Component } from '@angular/core';
import { JudoServiceService, ITechniek } from './judo-service.service';
import { NumberValueAccessor } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  
  getId:number;
  paginaNummer:number=1;

  data1:number;
  data2:number;
  
  
  naam:string;
  type:string;
  moeilijkheidsgraad:string;
  url?:any;
  gordel?:any;
  techniekPersonen?:any;
 
  lijstTechnieken: ITechniek[];
   

  
  

  constructor(private service: JudoServiceService){
    this.service.GetData(this.getId).subscribe((result) =>{
      console.log(result);

      this.naam=result.naam;
      this.type=result.type;
     
      
    });
  }

  getAll=()=>{
    this.getId=null;
    this.data1=0;
    this.data2=1;
    this.service.GetAllData().subscribe((result) =>{
      console.log(result);
      this.lijstTechnieken=result;

      
  });
}

Search=()=>{
  this.data1=1;
  this.data2=0;
  this.service.GetData(this.getId).subscribe((result) =>{
    console.log(result);

    this.naam=result.naam;
    this.type=result.type;
    this.moeilijkheidsgraad=result.moeilijkheidsgraad;
    this.url=result.url;
    this.gordel=result.gordel;
    this.techniekPersonen=result.techniekPersonen;
   
    
  });
}



}
