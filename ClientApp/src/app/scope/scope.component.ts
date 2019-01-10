import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-scope',
  templateUrl: './scope.component.html',
  styleUrls: ['./scope.component.css']
})
export class ScopeComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }
  saveAgent(){
    console.log("Great Button Press");
  }
}
