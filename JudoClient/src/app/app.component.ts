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
  krijgTechniek:string="o-soto-gari";

  inputNaam:string="osato-ko";
  inputType:string="heupworp";
  inputGraad:string="gemiddeld";
  //inputURL:string
  

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

  
 
  lijstTechnieken: ITechniek[];
  
  postData={
    naam: this.inputNaam,
    moeilijkheidsgraad: this.inputGraad,
    Type: this.inputType
  };

  data={
    Email: "InventoryAdmin@abc.com",
	Password: "$admin@2017"
  }
  //token:string;

 
  counterType:number=1;
  counterGraad:number=1;
  filterType:string;
  filterGraad:string;
  

  
  
   

  
  

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
KrijgTechniekOpNaam=()=>{
  this.paginaNummer=0;
  this.tabel1=1;
  this.tabel2=0;
  this.service.KrijgTechniekOpNaam(this.krijgTechniek).subscribe((resultaat)=>{
    console.log(resultaat);

    this.naam=resultaat.naam;
    this.type=resultaat.type;
    this.moeilijkheidsgraad=resultaat.moeilijkheidsgraad;
    this.url=resultaat.url;
    this.gordel=resultaat.gordel;
    this.techniekPersonen=resultaat.techniekPersonen;
  })
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


filter=()=>{
  if(this.counterType==1 && this.counterGraad==1){
    this.filterType="Beenworp";
    this.filterGraad="Makkelijk";
  }
  else if(this.counterType==1 && this.counterGraad==2){
    this.filterType="Beenworp";
    this.filterGraad="Gemiddeld";
  }
  else if(this.counterType==1 && this.counterGraad==3){
    this.filterType="Beenworp";
    this.filterGraad="Moeilijk";
  }
  else if(this.counterType==2 && this.counterGraad==1){
    this.filterType="Schouderworp";
    this.filterGraad="Makkelijk";
  }
  else if(this.counterType==2 && this.counterGraad==2){
    this.filterType="Schouderworp";
    this.filterGraad="Gemiddeld";
  }
  else if(this.counterType==2 && this.counterGraad==3){
    this.filterType="Schouderworp";
    this.filterGraad="Moeilijk";
  }
  else if(this.counterType==3 && this.counterGraad==1){
    this.filterType="Heupworp";
    this.filterGraad="Makkelijk";
  }
  else if(this.counterType==3 && this.counterGraad==2){
    this.filterType="Heupworp";
    this.filterGraad="Gemiddeld";
  }
  else if(this.counterType==3 && this.counterGraad==3){
    this.filterType="Heupworp";
    this.filterGraad="Moeilijk";
  }
  this.tabel1=0;
  this.tabel2=1;
  this.service.Filtering(this.filterType,this.filterGraad).subscribe((resultaat)=>{
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
inloggen=()=>{
  this.service.inloggen(this.data).subscribe((resultaat)=>{
    console.log(resultaat);


});



}

paginaZettenPrevious=()=>{
  if(this.paginaNummer>=1) {
    this.paginaNummer--;
    this.tabel1=0;
    this.tabel2=1;
    this.service.KrijgPagina(this.paginaNummer).subscribe((resultaat)=>{
      console.log(resultaat)

      this.lijstTechnieken=resultaat;


    });
  }
}
paginaZetten1=()=>{
  this.paginaNummer=0;
  this.tabel1=0;
  this.tabel2=1;
  this.service.KrijgPagina(this.paginaNummer).subscribe((resultaat)=>{
    console.log(resultaat)

    this.lijstTechnieken=resultaat;


  });

}
paginaZetten2=()=>{
  this.paginaNummer=1;
  this.tabel1=0;
  this.tabel2=1;
  this.service.KrijgPagina(this.paginaNummer).subscribe((resultaat)=>{
    console.log(resultaat)

    this.lijstTechnieken=resultaat;


  });

}
paginaZetten3=()=>{
  this.paginaNummer=2;
  this.tabel1=0;
  this.tabel2=1;
  this.service.KrijgPagina(this.paginaNummer).subscribe((resultaat)=>{
    console.log(resultaat)

    this.lijstTechnieken=resultaat;


  });

}
paginaZetten4=()=>{
  this.paginaNummer=3;
  this.tabel1=0;
  this.tabel2=1;
  this.service.KrijgPagina(this.paginaNummer).subscribe((resultaat)=>{
    console.log(resultaat)

    this.lijstTechnieken=resultaat;


  });

}
paginaZetten5=()=>{
  this.paginaNummer=4;
  this.tabel1=0;
  this.tabel2=1;
  this.service.KrijgPagina(this.paginaNummer).subscribe((resultaat)=>{
    console.log(resultaat)

    this.lijstTechnieken=resultaat;


  });

}
paginaZetten6=()=>{
  this.paginaNummer=5;
  this.tabel1=0;
  this.tabel2=1;
  this.service.KrijgPagina(this.paginaNummer).subscribe((resultaat)=>{
    console.log(resultaat)

    this.lijstTechnieken=resultaat;


  });

}
paginaZettenNext=()=>{
  if(this.paginaNummer<=4){
    this.paginaNummer++;
  }
  this.tabel1=0;
  this.tabel2=1;
  this.service.KrijgPagina(this.paginaNummer).subscribe((resultaat)=>{
    console.log(resultaat)

    this.lijstTechnieken=resultaat;


  });

}

}
