import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ActiviteitenroosterService {

  constructor(
    private http: HttpClient
  ) { }
  activiteitSpecific = {}
  notDone = true;

  //Sends a http request to the API to receive a specific activiteitenrooster
  getSpecificActiviteit(wantedID) {
    const url = environment.apiUrl + "Activiteitenrooster/" + wantedID
    this.http.get(url)
    .subscribe(
      data => {
        this.activiteitSpecific = data
        this.notDone = false
      },
      error => {
        console.log(error)
      }
    )
  }
}
