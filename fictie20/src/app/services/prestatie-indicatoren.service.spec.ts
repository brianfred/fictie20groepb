import { TestBed } from '@angular/core/testing';

import { PrestatieIndicatorenService } from './prestatie-indicatoren.service';

describe('PrestatieIndicatorenService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: PrestatieIndicatorenService = TestBed.get(PrestatieIndicatorenService);
    expect(service).toBeTruthy();
  });
});
