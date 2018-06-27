import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ArtikalListComponent } from './components/artikal-components/artikal-list/artikal-list.component';
import { ArtikalItemComponent } from './components/artikal-components/artikal-item/artikal-item.component';
import { ArtikalAddComponent } from './components/artikal-components/artikal-add/artikal-add.component';
import { ArtikalService } from './services/artikal.service';
import { MessageService } from './services/message.service';
import { MessageListComponent } from './components/message-components/message-list/message-list.component';


@NgModule({
  declarations: [
    AppComponent,
    ArtikalListComponent,
    ArtikalItemComponent,
    ArtikalAddComponent,
    MessageListComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [ArtikalService, MessageService],
  bootstrap: [AppComponent]
})
export class AppModule { }
