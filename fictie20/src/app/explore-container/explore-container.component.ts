import { Component, OnInit, Input } from '@angular/core';
import { ModuleService } from 'src/app/services/module.service';
import { PrestatieIndicatorenService } from 'src/app/services/prestatie-indicatoren.service'; 

@Component({
  selector: 'app-explore-container',
  templateUrl: './explore-container.component.html',
  styleUrls: ['./explore-container.component.scss'],
})
export class ExploreContainerComponent implements OnInit {
  @Input() name: string;

  project: string;

  constructor(
    private moduleService: ModuleService,
    private piService: PrestatieIndicatorenService,
  ) { }

  ngOnInit() {
    this.moduleService.getAllModules();
    this.piService.getAllPIs();
  }

  currentModule = ''

  //Makes a call to the moduleService to get all the data for 1 specific module
  getModule(wantedModule) {
    this.moduleService.getSpecificModule(wantedModule)
  }

  //Finds out which module has been selected based on the ID of the module
  selectModule(chosenModule){
    var module = chosenModule.split(" ");
    if (module[0] != 0) {
      this.currentModule = module[0]
      this.getModule(module[0])
      this.piService.getSpecificPI(module)
      this.reset()
    }
  }

  //Makes sure the selected module is correct on every page
  reset() {
    this.project = null
  }

}
