import { NgModule } from '@angular/core';
import { RouterModule, Route } from '@angular/router';
import { ArtikalListComponent } from './components/artikal-components/artikal-list/artikal-list.component';
import { ArtikalAddComponent } from './components/artikal-components/artikal-add/artikal-add.component';
import { ArtikalEditComponent } from './components/artikal-components/artikal-edit/artikal-edit.component';

const routes: Route[] = [
  { path: 'artikli', component: ArtikalListComponent},
  { path: 'add', component: ArtikalAddComponent},
  { path: 'edit/:id', component: ArtikalEditComponent},
  { path: '', redirectTo: '/artikli', pathMatch: 'full'}
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }
