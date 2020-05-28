import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class YoutubeService {

   constructor(private http: HttpClient) { }

   KrijgVideo(naam:string){
    return this.http.get<Id>(`https://www.googleapis.com/youtube/v3/search?part=snippet&maxResults=1&q=${naam}&key=AIzaSyAELPrFpHnuvoz0ou7W4XSVMKVecnWZoFI`);
   }
   
 }

 

  export interface PageInfo {
      totalResults: number;
      resultsPerPage: number;
  }

  export interface Id {
      kind: string;
      videoId: string;
  }

  export interface Default {
      url: string;
      width: number;
      height: number;
  }

  export interface Medium {
      url: string;
      width: number;
      height: number;
  }

  export interface High {
      url: string;
      width: number;
      height: number;
  }

  export interface Thumbnails {
      default: Default;
      medium: Medium;
      high: High;
  }

  export interface Snippet {
      publishedAt: Date;
      channelId: string;
      title: string;
      description: string;
      thumbnails: Thumbnails;
      channelTitle: string;
      liveBroadcastContent: string;
      publishTime: Date;
  }

  export interface Item {
      kind: string;
      etag: string;
      id: Id;
      snippet: Snippet;
  }

  export interface youtube {
      kind: string;
      etag: string;
      nextPageToken: string;
      regionCode: string;
      pageInfo: PageInfo;
      items: Item[];
  }


