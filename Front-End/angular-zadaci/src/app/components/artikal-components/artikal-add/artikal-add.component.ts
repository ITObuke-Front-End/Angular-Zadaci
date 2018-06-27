import { Component, OnInit } from '@angular/core';
import { Artikal } from '../../../models/Artikal';
import { ArtikalService } from '../../../services/artikal.service';

@Component({
  selector: 'app-artikal-add',
  templateUrl: './artikal-add.component.html',
  styleUrls: ['./artikal-add.component.css']
})
export class ArtikalAddComponent implements OnInit {
  artikal: Artikal;

  constructor(private artikalService: ArtikalService) {
    this.artikal = new Artikal();
   }

  ngOnInit() {
  }

  addArtikal(sifra: string, naziv: string, cena: number, opis: string, tipArtikla: string) {
    this.artikal.sifra = sifra;
    this.artikal.naziv = naziv;
    this.artikal.cena = cena;
    this.artikal.opis = opis;
    this.artikal.tipArtikla = tipArtikla;
    this.artikal.slikaUrl = '';

    this.artikalService.addArtikal(this.artikal)
    .subscribe((artikal: Artikal) =>  { alert('Artikal ' + artikal.naziv + ' je uspešno dodat!'); });

    return false;
  }

}
