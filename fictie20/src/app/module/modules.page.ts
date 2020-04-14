import { Component } from '@angular/core';
import { ModuleService } from 'src/app/services/module.service';

@Component({
  selector: 'app-module',
  templateUrl: 'modules.page.html',
  styleUrls: ['modules.page.scss']
})
export class modulePage {

  constructor(
    private moduleService: ModuleService,
  ) {} 
}
