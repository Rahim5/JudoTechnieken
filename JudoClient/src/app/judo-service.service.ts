import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class JudoServiceService {
  
  

  
  

  constructor(private http: HttpClient) { }

  KrijgData(id:number){
    return this.http.get<ITechniek>(`https://localhost:44377/api/v1/technieken/${id}`)
   
  
  }
  KrijgTechniekOpNaam(naam:string){
    return this.http.get<ITechniek>(`https://localhost:44377/api/v1/technieken/?naam=${naam}`)
  }
  KrijgAlleData(){
    return this.http.get<ITechniek[]>("https://localhost:44377/api/v1/technieken/");
  }

  KrijgPagina(paginaNummer:number){
    return this.http.get<ITechniek[]>(`https://localhost:44377/api/v1/technieken/?pagina=${paginaNummer}`)
  }

  Filtering(type:string,graad:string){
      return this.http.get<ITechniek[]>(`https://localhost:44377/api/v1/technieken/?type=${type}&moeilijkheidsgraad=${graad}`)
   
  }

VerwijderData(id:number){
  return this.http.delete<ITechniek[]>(`https://localhost:44377/api/v1/technieken/${id}`)
}

VerstuurData(Body:any){
  return this.http.post<ITechniek>("https://localhost:44377/api/v1/technieken/",Body)
}

inloggen(Body:any){
  return this.http.post<any>("https://localhost:44377/api/token", Body )
}

aanpassen(id:number, body: any){
  return this.http.put<ITechniek>(`https://localhost:44377/api/v1/technieken/${id}`, body)
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

export class Techniek{
  naam: string;
  type: string;
  moeilijkheidsgraad: string;
  url?: any;
  gordel?: any;
  techniekPersonen?: any;
}

