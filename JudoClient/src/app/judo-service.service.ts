import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class JudoServiceService {
  
  techniekId: number;
  naam: string;
  type: string;
  moeilijkheidsgraad: string;
  url?: any;
  gordel?: any;
  techniekPersonen?: any;

  body={
    naam: this.naam,
    type: this.type,
    moeilijkheidsgraad: this.moeilijkheidsgraad,
    url: this.url,
    gordel:this.gordel,
    techniekPersonen:this.techniekPersonen
  }
  

  constructor(private http: HttpClient) { }

  KrijgData(id:number){
    return this.http.get<ITechniek>(`https://localhost:44377/api/v1/technieken/${id}`)
   
  
  }
  KrijgAlleData(){
    return this.http.get<ITechniek[]>("https://localhost:44377/api/v1/technieken/");
  }

  KrijgPagina(paginaNummer:number){
    return this.http.get<ITechniek[]>(`https://localhost:44377/api/v1/technieken?pagina=${paginaNummer}`)
  }

  Filtering(filter:string, flag:number){
    if(flag==1){
      return this.http.get<ITechniek[]>(`https://localhost:44377/api/v1/technieken?naam=${filter}`)
    }
    else if(flag==2){
      return this.http.get<ITechniek[]>(`https://localhost:44377/api/v1/technieken?moeilijkheidsgraad=${filter}`)
    }
    else if(flag==3){
      return this.http.get<ITechniek[]>(`https://localhost:44377/api/v1/technieken?type=${filter}`)
    }
  }

VerwijderData(id:number){
  return this.http.delete<ITechniek[]>(`https://localhost:44377/api/v1/technieken/${id}`)
}

VerstuurData(){
  return this.http.post<ITechniek>("https://localhost:44377/api/v1/technieken/",this.body)
  
}
 
}
export interface ITechniek {
  techniekId: number;
  naam: string;
  type: string;
  moeilijkheidsgraad: string;
  url?: any;
  gordel?: any;
  techniekPersonen?: any;
}

