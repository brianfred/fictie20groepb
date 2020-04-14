import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ProcesverbaalService {

  constructor(
    private http: HttpClient
  ) { }

  procesverbaalSpecific = {}
  notFoundPV = true

  //Gets a specific proces verbaal from the API
  getProcesVerbaal(studentID, moduleID) {
    const url = environment.apiUrl + "procesverbaal/" + studentID + '/' + moduleID
    this.http.get(url)
    .subscribe(
      data => {
        this.procesverbaalSpecific = data
        if (this.procesverbaalSpecific == null) {
          this.notFoundPV = true
          this.procesverbaalSpecific = {}
        }
        else {
          this.notFoundPV = false
        }
      },
      error => {
        console.log(error)
      },
    )
  }
}
