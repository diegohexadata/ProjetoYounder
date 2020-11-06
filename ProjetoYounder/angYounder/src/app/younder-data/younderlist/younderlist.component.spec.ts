import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { YounderlistComponent } from './younderlist.component';

describe('YounderlistComponent', () => {
  let component: YounderlistComponent;
  let fixture: ComponentFixture<YounderlistComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ YounderlistComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(YounderlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
