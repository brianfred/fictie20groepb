import { Component, OnInit } from '@angular/core';
import { InlogService } from 'src/app/services/inlog.service'

@Component({
  selector: 'app-login',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.scss'],
})
export class LoginPage implements OnInit {
  username: string
  password: string

  constructor(
    private inlogService: InlogService
  ) { }

  ngOnInit() {
  }

  //Makes a call to the inlogService with the entered username and password
  login() {
    this.inlogService.login(this.username, this.password)
  }

  //Makes a logout call to the inlogservice
  logout() {
    this.inlogService.logout()
  }
}
