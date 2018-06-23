import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ArtikalListComponent } from './components/artikal-components/artikal-list/artikal-list.component';
import { ArtikalItemComponent } from './components/artikal-components/artikal-item/artikal-item.component';

@NgModule({
  declarations: [
    AppComponent,
    ArtikalListComponent,
    ArtikalItemComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
