import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { procesVerbaalPage } from './procesVerbaal.page';

describe('procesVerbaalPage', () => {
  let component: procesVerbaalPage;
  let fixture: ComponentFixture<procesVerbaalPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ procesVerbaalPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(procesVerbaalPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
