import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { StatsService } from '../services/stats.service';
import { GameDetails } from '../models/GameDetails';
import { firstValueFrom } from 'rxjs';

@Component({
  selector: 'app-music-notes-stats',
  templateUrl: './music-notes-stats.component.html',
  styleUrl: './music-notes-stats.component.css'
})
export class MusicNotesStatsComponent implements OnInit{

  gameDetails: GameDetails[] = [];

  constructor(private statsService: StatsService) { }

  ngOnInit(): void {
    this.statsService.getAllGameDetails().subscribe({
      next: (data) => this.gameDetails = data,
      error: (err) => console.error('Error fetching game details', err)
    });
  }
}
