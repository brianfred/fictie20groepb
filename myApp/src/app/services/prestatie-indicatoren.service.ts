import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class PrestatieIndicatorenService {
  constructor(
    private http: HttpClient,
  ) { }

  public piList = []
  public piSpecific = []
  notDone = true

  //Sends a http request to the api to receive all the prestatie-indicatoren
  getAllPIs() {
    const url = environment.apiUrl + "prestatieindicatoren/"
    return this.http.get(url)
    .subscribe(
      data => {
        this.putDataInList(data);
        this.notDone = false
      },
      error => {
        console.log(error)
      }
    )
  }

  //Sends a http request to the api to receive a specific prestatie-indicator
  getSpecificPI(wantedID) {
    this.piSpecific = []
    for (var index in this.piList){
      if (this.piList[index].moduleID == wantedID[0]) {
        this.piSpecific.push(this.piList[index])
      }
    }
  }  

  //Put the data in a list
  putDataInList(receivedPrestatieIndicatoren){
    this.piList = receivedPrestatieIndicatoren
  }
}
