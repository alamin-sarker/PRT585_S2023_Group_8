import { Component, OnInit } from '@angular/core';
import { NgModel } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent{
  username: string = '';
  password: string = '';
  
  // constructor(private http: HttpClient) {}

  submit() 
  {
    const data = {
    username: this.username,
    password: this.password,
  };

  // Replace 'http://localhost:5115' with the actual URL of your backend API
  const apiUrl = 'http://localhost:5115/api/login'; // Replace '/api/login' with your API endpoint

  // Send a POST request to your backend
  // this.http.post(apiUrl, data).subscribe(
  //   (response: any) => {
  //     console.log('Response from server:', response);
  //     // Handle the response from the server here
  //   },
  //   (error: any) => {
  //     console.error('Error:', error);
  //     // Handle any errors that occur during the request
  //   }
  // );
}
}