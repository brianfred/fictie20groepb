import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { InlogService } from 'src/app/services/inlog.service'
import { analyzeAndValidateNgModules } from '@angular/compiler';

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

  login() {
    this.inlogService.login(this.username, this.password)
  }

  logout() {
    this.inlogService.logout()
  }
}
