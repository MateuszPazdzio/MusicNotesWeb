import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MusicNotesStatsComponent } from './music-notes-stats/music-notes-stats.component';

const routes: Routes = [
  {path : '', component : MusicNotesStatsComponent}
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
