import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { YounderComponent } from './younder.component';

describe('YounderComponent', () => {
  let component: YounderComponent;
  let fixture: ComponentFixture<YounderComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ YounderComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(YounderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
