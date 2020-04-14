import { TestBed } from '@angular/core/testing';

import { ActiviteitenroosterService } from './activiteitenrooster.service';

describe('ActiviteitenroosterService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ActiviteitenroosterService = TestBed.get(ActiviteitenroosterService);
    expect(service).toBeTruthy();
  });
});
