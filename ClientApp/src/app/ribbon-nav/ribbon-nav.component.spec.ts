import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RibbonNavComponent } from './ribbon-nav.component';

describe('RibbonNavComponent', () => {
  let component: RibbonNavComponent;
  let fixture: ComponentFixture<RibbonNavComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RibbonNavComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RibbonNavComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
