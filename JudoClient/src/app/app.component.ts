import { Component } from '@angular/core';
import { JudoServiceService, ITechniek, Techniek } from './judo-service.service';
import { NumberValueAccessor } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  
  KrijgId:number;
  verwijderId:number;
  paginaNummer:number=0;
  

  tabel1:number;
  tabel2:number;
  
  filterText:string;
  naamChecked:boolean;
  moeilijkheidsgraadChecked:boolean;
  typeChecked:boolean;
  filterNummer:number;
  
  naam:string;
  type:string;
  moeilijkheidsgraad:string;
  url?:any;
  gordel?:any;
  techniekPersonen?:any;

  NaamTechniek:string="wat the fak man";
 
  lijstTechnieken: ITechniek[];
  
  postData={
    naam:"wat the fak is dees",
    moeilijkheidsgraad: "makkelijk",
    Type: "beenworp",
  };
  
  

  
  
   

  
  

  constructor(private service: JudoServiceService){
    this.service.KrijgData(this.KrijgId).subscribe((resultaat) =>{
      console.log(resultaat);

      
     
      
    });
  }

  KrijgAlles=()=>{
    this.paginaNummer=0;
    this.KrijgId=null;
    this.tabel1=0;
    this.tabel2=1;
    this.service.KrijgAlleData().subscribe((resultaat) =>{
      console.log(resultaat);
      this.lijstTechnieken=resultaat;

      
  });
}

Zoek=()=>{
  this.paginaNummer=0;
  this.tabel1=1;
  this.tabel2=0;
  this.service.KrijgData(this.KrijgId).subscribe((resultaat) =>{
    console.log(resultaat);

    this.naam=resultaat.naam;
    this.type=resultaat.type;
    this.moeilijkheidsgraad=resultaat.moeilijkheidsgraad;
    this.url=resultaat.url;
    this.gordel=resultaat.gordel;
    this.techniekPersonen=resultaat.techniekPersonen;
   
    
  });
}
KrijgFilter=()=>{
  
  if(this.naamChecked==true){
    this.filterNummer=1;
  }
  if(this.moeilijkheidsgraadChecked==true){
    this.filterNummer=2;
  }
  if(this.typeChecked==true){
    this.filterNummer=3;
  }

  this.service.Filtering(this.filterText,this.filterNummer).subscribe((resultaat) =>{
    console.log(resultaat);
    this.lijstTechnieken=resultaat;
});
}
  

KrijgPagina=()=>{
  this.service.KrijgPagina(this.paginaNummer).subscribe((resultaat) =>{
    console.log(resultaat);
    this.lijstTechnieken=resultaat;
});
}

VerwijderTechniek=()=>{
  this.service.VerwijderData(this.verwijderId).subscribe((resultaat) =>{
    console.log(resultaat);
    this.lijstTechnieken=resultaat;
    
});

}

DataToevoegen=()=>{
  this.service.VerstuurData(this.postData).subscribe((resultaat) =>{
    console.log(resultaat);
    
    
    
    
});

}




}
