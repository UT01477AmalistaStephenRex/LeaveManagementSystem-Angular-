import { Component } from '@angular/core';
import { LoginComponent } from './login/login.component';

@Component({
  selector: 'app-user',
  standalone: true,
  imports: [LoginComponent],
  templateUrl: './user.component.html',
  styles: ``
})
export class UserComponent {

}
