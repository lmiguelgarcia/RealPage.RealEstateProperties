import { TestBed } from '@angular/core/testing';

import { PropertyTypeService } from './propertyType.service';

describe('PropertyTypeService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: PropertyTypeService = TestBed.get(PropertyTypeService);
    expect(service).toBeTruthy();
  });
});
