import { TestBed } from '@angular/core/testing';

import { YounderService } from './younder.service';

describe('YounderService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: YounderService = TestBed.get(YounderService);
    expect(service).toBeTruthy();
  });
});
