import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { YounderDataComponent } from './younder-data.component';

describe('YounderDataComponent', () => {
  let component: YounderDataComponent;
  let fixture: ComponentFixture<YounderDataComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ YounderDataComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(YounderDataComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
