import { HttpClient } from '@angular/common/http'; 
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-weather',
  templateUrl: './weather.component.html',
  styleUrls: ['./weather.component.css']
})
export class WeatherComponent implements OnInit {
  weathers: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getWeathers();
  }

  getWeathers() {

    this.http.get('http://localhost:5091/weatherforecast').subscribe(response => {
      this.weathers = response;
    }, error => {
      console.log(error);
    });

  }

}
