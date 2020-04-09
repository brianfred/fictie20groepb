import { Component, OnInit } from '@angular/core';
import { ProcesverbaalService } from 'src/app/services/procesverbaal.service';

@Component({
  selector: 'app-tab4',
  templateUrl: './tab4.page.html',
  styleUrls: ['./tab4.page.scss'],
})
export class Tab4Page implements OnInit {

  constructor(
    private procesverbaalService: ProcesverbaalService
  ) { }

  ngOnInit() {
  }

}
