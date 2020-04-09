import { TestBed } from '@angular/core/testing';

import { ProcesverbaalService } from './procesverbaal.service';

describe('ProcesverbaalService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ProcesverbaalService = TestBed.get(ProcesverbaalService);
    expect(service).toBeTruthy();
  });
});
