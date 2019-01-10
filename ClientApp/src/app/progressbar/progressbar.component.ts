import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-progressbar',
  templateUrl: './progressbar.component.html',
  styleUrls: ['./progressbar.component.css']
})
export class ProgressbarComponent implements OnInit {

  color = 'primary';
  mode = 'indeterminate';

 

  constructor() { }

  ngOnInit() {
  }

}
