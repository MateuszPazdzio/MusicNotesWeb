import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MusicNotesStatsComponent } from './music-notes-stats.component';

describe('MusicNotesStatsComponent', () => {
  let component: MusicNotesStatsComponent;
  let fixture: ComponentFixture<MusicNotesStatsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MusicNotesStatsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MusicNotesStatsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
