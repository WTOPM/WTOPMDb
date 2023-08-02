import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  users: any;

  constructor(private http: HttpClient) { }

    ngOnInit() {
      this.getUsers();
  }

  getUsers() {
    this.http.get("http://localhost:5091/users").subscribe(response => {
      this.users = response;
    }, error => {
      console.log(error);
    });
  }

}
