import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { PropertyService } from './property.service';
import { PropertyTypeService } from './propertyType.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import {MatSelectModule} from '@angular/material/select';
import {
  MatButtonModule, MatMenuModule, MatDatepickerModule, MatNativeDateModule , MatIconModule, MatCardModule, MatSidenavModule, MatFormFieldModule,
  MatInputModule, MatTooltipModule, MatToolbarModule
} from '@angular/material';
import { MatRadioModule } from '@angular/material/radio';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PropertyComponent } from './property/property.component';

@NgModule({
  declarations: [
    AppComponent,
    PropertyComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    MatSelectModule,
    ReactiveFormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatMenuModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatIconModule,
    MatRadioModule,
    MatCardModule,
    MatSidenavModule,
    MatFormFieldModule,
    MatInputModule,
    MatTooltipModule,
    MatToolbarModule,
    MatSelectModule,
    AppRoutingModule
  ],
  providers: [HttpClientModule, PropertyService, PropertyTypeService, MatDatepickerModule],
  bootstrap: [AppComponent]
})
export class AppModule { }
