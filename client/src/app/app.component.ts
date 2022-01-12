import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({ 
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit { //comes after the constructor
  title = 'The Dating App';
  users: any; //anytype

  constructor(private http: HttpClient) {}


  ngOnInit() {
    this.getUsers(); // calls get users method
  }

  getUsers(){
    this.http.get('https://localhost:5001/api/users').subscribe(response => { //gets http and sends reponse (response contain response you get from api server)
      this.users = response; //users is the response given
    }, error => {
      console.log(error); //if error logs in console
    })

  }
}
