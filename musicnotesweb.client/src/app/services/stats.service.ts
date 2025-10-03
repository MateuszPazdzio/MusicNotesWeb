import { Injectable } from '@angular/core';
import { GameDetails } from '../models/GameDetails';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StatsService {
  //private apiUrl = 'http://localhost:5000/api/MusicNotesStats';
  private apiUrl = '/api/MusicNotesStats'; // relative path

  constructor(private httpClient: HttpClient) { }


  getAllGameDetails(): Observable<GameDetails[]> {
    return this.httpClient.get<GameDetails[]>(this.apiUrl)
  }
}
