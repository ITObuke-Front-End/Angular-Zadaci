import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ArtikalListComponent } from './components/artikal-components/artikal-list/artikal-list.component';

@NgModule({
  declarations: [
    AppComponent,
    ArtikalListComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
