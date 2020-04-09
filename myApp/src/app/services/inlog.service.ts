import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ProcesverbaalService } from 'src/app/services/procesverbaal.service';

@Injectable({
  providedIn: 'root'
})
export class InlogService {
  public tekstje = '';
  public gebruiker: any;
  public ingelogd = false;
  private anyVariable: any

  constructor(
    private http: HttpClient,
    private procesverbaalService: ProcesverbaalService
  ) { }

  login(username, password) {
    const url = environment.apiUrl + "gebruiker/" + username + "/" + password
    this.http.get(url)
    .subscribe(
      data => {
        if (data == null) {
          this.tekstje = "Inlog niet succesvol"
          this.gebruiker = {}
          this.ingelogd = false
        }
        else {
          this.tekstje = "Inlog succesvol"
          this.gebruiker = data
          this.ingelogd = true
        }

        this.procesverbaalService.procesverbaalSpecific = {}
        this.procesverbaalService.notFoundPV = true

      },
      error => {
        console.log(error)
      }
    )
  }

  logout() {
    this.tekstje = 'Uitgelogd';
    this.gebruiker = this.anyVariable;
    this.ingelogd = false;
    this.procesverbaalService.procesverbaalSpecific = {}
    this.procesverbaalService.notFoundPV = true
  }
}
