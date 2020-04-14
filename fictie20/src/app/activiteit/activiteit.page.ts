import { Component } from '@angular/core';
import { ActiviteitenroosterService } from 'src/app/services/activiteitenrooster.service';

@Component({
  selector: 'app-activiteit',
  templateUrl: 'activiteit.page.html',
  styleUrls: ['activiteit.page.scss']
})
export class activiteitPage {
  constructor(
    private activiteitService: ActiviteitenroosterService
    ) {}

}
