import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { YounderDataComponent } from './younder-data/younder-data.component';
import { YounderComponent } from './younder/younder.component';
import { YounderlistComponent } from './younder-data/younderlist/younderlist.component';

@NgModule({
  declarations: [
    AppComponent,
    YounderDataComponent,
    YounderComponent,
    YounderlistComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
