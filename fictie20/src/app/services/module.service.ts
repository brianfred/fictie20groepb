import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ActiviteitenroosterService } from 'src/app/services/activiteitenrooster.service';
import { ProcesverbaalService } from 'src/app/services/procesverbaal.service';
import { InlogService } from 'src/app/services/inlog.service';

@Injectable({
  providedIn: 'root'
})
export class ModuleService {

  constructor(
    private http: HttpClient,
    private activiteitService: ActiviteitenroosterService,
    private procesverbaalService: ProcesverbaalService,
    private inlogService: InlogService
  ) { }
  
  moduleList = []
  moduleSpecific = {}
  activiteitenID: any
  notDone = true

  //Send a http request to the API to receive all the modules in the database
  getAllModules() {
    const url = environment.apiUrl + "module/"
    return this.http.get(url)
    .subscribe(
      data => {
        this.putDataInList(data);
      },
      error => {
        console.log(error)
      }
    )
  }

  //Sends a http request to the API to receive a specific module
  getSpecificModule(wantedID) {
    const url = environment.apiUrl + "module/" + wantedID
    this.http.get(url)
    
    .subscribe(
      data => {
        this.moduleSpecific = data
        this.activiteitenID = data
        this.activiteitService.getSpecificActiviteit(this.activiteitenID.activiteitenRoosterID)
        if (this.inlogService.ingelogd == true) {
          this.procesverbaalService.getProcesVerbaal(this.inlogService.gebruiker.gebruikersnaam, this.activiteitenID.moduleID)
        }
        this.notDone = false  
      },
      error => {
        console.log(error)
      },
    )
  }

  putDataInList(receivedModules){
    this.moduleList = receivedModules
  }
}
