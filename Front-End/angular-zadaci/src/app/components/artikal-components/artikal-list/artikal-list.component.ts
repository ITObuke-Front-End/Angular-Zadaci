import { Component, OnInit } from '@angular/core';
import { Artikal } from '../../../models/Artikal';
import { ARTIKLI } from '../../../mock/mock-artikli';

@Component({
  selector: 'app-artikal-list',
  templateUrl: './artikal-list.component.html',
  styleUrls: ['./artikal-list.component.css']
})
export class ArtikalListComponent implements OnInit {

  artikli: Artikal[] = ARTIKLI;

  constructor() { }

  ngOnInit() {
  }

}
