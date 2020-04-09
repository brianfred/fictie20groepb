import { Component } from '@angular/core';
import { PrestatieIndicatorenService } from 'src/app/services/prestatie-indicatoren.service'; 

@Component({
  selector: 'app-tab2',
  templateUrl: 'tab2.page.html',
  styleUrls: ['tab2.page.scss']
})
export class Tab2Page {

  constructor(
    private piService: PrestatieIndicatorenService
  ) {}
}
