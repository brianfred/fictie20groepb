import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';
import { ExploreContainerComponentModule } from '../explore-container/explore-container.module';

import { activiteitPage } from './activiteit.page';

describe('activiteitPage', () => {
  let component: activiteitPage;
  let fixture: ComponentFixture<activiteitPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [activiteitPage],
      imports: [IonicModule.forRoot(), ExploreContainerComponentModule]
    }).compileComponents();

    fixture = TestBed.createComponent(activiteitPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
