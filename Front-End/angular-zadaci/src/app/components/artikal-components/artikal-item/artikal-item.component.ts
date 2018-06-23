import { Component, OnInit, Input } from '@angular/core';
import { Artikal } from '../../../models/Artikal';

@Component({
  selector: 'app-artikal-item',
  templateUrl: './artikal-item.component.html',
  styleUrls: ['./artikal-item.component.css']
})
export class ArtikalItemComponent implements OnInit {
  @Input() artikal: Artikal;

  constructor() { }

  ngOnInit() {
  }

}
