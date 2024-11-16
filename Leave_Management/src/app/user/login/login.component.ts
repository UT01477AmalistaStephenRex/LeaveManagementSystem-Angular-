import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [ReactiveFormsModule,CommonModule],
  templateUrl: './login.component.html',
  styles: ``
})
export class LoginComponent {
 form;
 constructor(
  public formBuilder: FormBuilder){

 this.form = this.formBuilder.group({
    userName : [''],
    password : [''],
    confirmPassword : ['']
 })
}

onSubmit(){
  console.log(this.form.value);
  
}

}
