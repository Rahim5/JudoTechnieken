import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class JudoServiceService {

  constructor(private http: HttpClient) { }

  GetData(){
    return this.http.get<ITechniek>("https://localhost:44377/api/v1/technieken/")
  
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