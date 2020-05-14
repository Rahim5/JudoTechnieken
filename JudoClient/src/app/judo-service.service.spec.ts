import { TestBed } from '@angular/core/testing';

import { JudoServiceService } from './judo-service.service';

describe('JudoServiceService', () => {
  let service: JudoServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(JudoServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
