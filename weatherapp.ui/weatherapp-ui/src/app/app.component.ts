import { Component, OnInit } from '@angular/core';
import { WeatherData } from './models/weather.model';
import { WeatherService } from './services/weather.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  
  constructor(private weatherService: WeatherService) {
    // this.weatherData = {
    //   cityName: '',
    //   temperature: 0,
    //   minimumTemperature: 0,
    //   maximumTemperature: 0,
    //   humidity: 0,
    //   windSpeed: 0
    // }
  }

  weatherData!: WeatherData;
  
  ngOnInit(): void {
    this.weatherService.getWeatherData('Heidenheim,Germany')
    .subscribe({
      next: (response) => {
        console.log(response);
        this.weatherData = response;
      }
    });
  }
}
