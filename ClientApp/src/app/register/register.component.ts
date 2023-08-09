import { Component, OnInit } from '@angular/core';
import { AlertifyService } from '../_services/alertify.service';
import { AuthService } from '../_services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  model: any = {};
  constructor(private authService: AuthService,
    private alertify: AlertifyService,
    private router: Router)
  { }
  ngOnInit() {

  }
  register() {
    this.authService.register(this.model).subscribe(() => {
      this.alertify.success('Registration successful');
      this.router.navigate(['/home']);
    }, validation => {
      this.alertify.error(validation.error.errors["Password"]["0"]);
      this.alertify.error(validation.error.errors["Username"]["0"]);
    });
  }
  cancel() {
    console.log('cancelled');
  }
}
