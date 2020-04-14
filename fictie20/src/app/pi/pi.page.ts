import { Component } from '@angular/core';
import { PrestatieIndicatorenService } from 'src/app/services/prestatie-indicatoren.service'; 

@Component({
  selector: 'app-pi',
  templateUrl: 'pi.page.html',
  styleUrls: ['pi.page.scss']
})
export class piPage {

  constructor(
    private piService: PrestatieIndicatorenService
  ) {}
}
