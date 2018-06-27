import { Component, OnInit } from '@angular/core';
import { Artikal } from '../../../models/Artikal';
import { ArtikalService } from '../../../services/artikal.service';

@Component({
  selector: 'app-artikal-list',
  templateUrl: './artikal-list.component.html',
  styleUrls: ['./artikal-list.component.css']
})
export class ArtikalListComponent implements OnInit {

  artikli: Artikal[];;

  constructor(private artikalService: ArtikalService) { }

  getArtikli(): void {
    this.artikalService.getArtikli()
    .subscribe( artikli => this.artikli = artikli);
  }

  ngOnInit() {
    this.getArtikli();
  }

}
