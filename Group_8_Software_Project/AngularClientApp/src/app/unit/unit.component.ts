import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Component } from '@angular/core';
import { Injectable } from '@angular/core';
import { Unit } from './unit';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';

@Component({
  selector: 'app-unit',
  templateUrl: './unit.component.html',
  styleUrls: ['./unit.component.css']
})

@Injectable()
export class UnitComponent {
  constructor(private http: HttpClient) {}

  Unit: Unit = {
    UnitId: 0,
    UnitName: "PRT585 - Software Engineering Practice" 
  }

  getUnitResponse(): Observable<HttpResponse<Unit>>{
    return this.http.get<Unit>("https://localhost:7246/api/Unit", {observe: 'response'}); 
  }

  showUnitResponse() {
    return this.getUnitResponse().subscribe(
      response => {
        const keys = response.headers.keys(); 
        const headers = keys.map(key =>
          `${key}: ${response.headers.get(key)}`);
          
        this.Unit = { ...response.body! };
      }
    ); 
  }

  data = this.showUnitResponse()

  log(data: any) {
    console.log(data)
  }
}
