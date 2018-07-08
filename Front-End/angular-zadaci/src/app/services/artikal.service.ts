import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';

import { Artikal } from '../models/Artikal';
import { MessageService } from './message.service';
import { environment } from '../../environments/environment';

@Injectable()
export class ArtikalService {
  private artikliUrl = environment.apiBaseUrl + '/artikal/';

  constructor(private httpClient: HttpClient, private messageService: MessageService) { }

  getArtikal(id: number): Observable<Artikal> {
    return this.httpClient
      .get<Artikal>(this.artikliUrl + id)
      .pipe(
        tap(a => this.log(`Učitan artikal sa id "${a.id}"`)),
        catchError(this.handleError<Artikal>('getArtikal')));
  }

  getArtikli(): Observable<Artikal[]> {
    return this.httpClient
      .get<Artikal[]>(this.artikliUrl)
      .pipe(
        tap(_ => this.log(`Učitani artikli`)),
        catchError(this.handleError<Artikal[]>('getArtikli')));
  }

  addArtikal(artikal: Artikal): Observable<Artikal> {
    return this.httpClient
      .post<Artikal>(this.artikliUrl, artikal)
      .pipe(
        tap(a => this.log(`Dodat artikal sa id "${a.id}"`)),
        catchError(this.handleError<Artikal>('addArtikal')));
  }

  updateArtikal(artikal: Artikal): Observable<Artikal> {
    return this.httpClient
      .put<Artikal>(this.artikliUrl, artikal)
      .pipe(
        tap(a => this.log(`Izmenjen artikal sa id "${a.id}"`)),
        catchError(this.handleError<Artikal>('updateArtikal')));
  }

  searchArtikli(term: string): Observable<Artikal[]> {
    return this.httpClient
      .get<Artikal[]>(`${this.artikliUrl}?naziv=${term}`)
      .pipe(
        tap(_ => this.log(`Nadjeni artikli sa nizovom "${term}"`)),
        catchError(this.handleError<Artikal[]>('searchArtikli', []))
    );
  }

  private log(message: string) {
    this.messageService.add('ArtikalService: ' + message);
  }

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error);
      this.log(`${operation} failed: ${error.message}`);
      return of(result as T);
    };
  }
}
