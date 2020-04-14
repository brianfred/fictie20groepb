import { Component, OnInit } from '@angular/core';
import { ProcesverbaalService } from 'src/app/services/procesverbaal.service';

@Component({
  selector: 'app-procesVerbaal',
  templateUrl: './procesVerbaal.page.html',
  styleUrls: ['./procesVerbaal.page.scss'],
})
export class procesVerbaalPage implements OnInit {

  constructor(
    private procesverbaalService: ProcesverbaalService
  ) { }

  ngOnInit() {
  }

}
