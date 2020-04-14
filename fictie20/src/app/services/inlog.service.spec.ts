import { TestBed } from '@angular/core/testing';

import { InlogService } from './inlog.service';

describe('InlogService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: InlogService = TestBed.get(InlogService);
    expect(service).toBeTruthy();
  });
});
