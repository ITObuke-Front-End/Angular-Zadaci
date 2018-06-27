import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { of } from 'rxjs';
import { Artikal } from '../models/Artikal';
import { ARTIKLI } from '../mock/mock-artikli';
import { MessageService } from './message.service';

@Injectable()
export class ArtikalService {

  constructor(private messageService: MessageService) { }

  getArtikli(): Observable<Artikal[]> {
    this.messageService.add('ArtikalService: Učitani artikli');
    return of(ARTIKLI);// privremeno resenje, bice promenjeno kada se uvede komunikacija s back-end-om
  }

  addArtikal(artikal: Artikal): Observable<Artikal> {
    this.messageService.add('ArtikalService: Dodat novi artikal');
    ARTIKLI.push(artikal);
    return of(artikal); // privremeno resenje, bice promenjeno kada se uvede komunikacija s back-end-om
  }
}
