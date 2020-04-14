import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';
import { ExploreContainerComponentModule } from '../explore-container/explore-container.module';

import { modulePage } from './modules.page';

describe('modulePage', () => {
  let component: modulePage;
  let fixture: ComponentFixture<modulePage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [modulePage],
      imports: [IonicModule.forRoot(), ExploreContainerComponentModule]
    }).compileComponents();

    fixture = TestBed.createComponent(modulePage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
