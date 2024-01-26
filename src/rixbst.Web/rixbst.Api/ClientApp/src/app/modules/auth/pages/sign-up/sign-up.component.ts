import { Component, OnInit } from '@angular/core';
import { AngularSvgIconModule } from 'angular-svg-icon';
import { RouterLink } from '@angular/router';
import { FormsModule, ReactiveFormsModule, FormGroup, FormBuilder } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'app-sign-up',
    templateUrl: './sign-up.component.html',
    styleUrls: ['./sign-up.component.scss'],
    standalone: true,
    imports: [
        FormsModule,
        ReactiveFormsModule,
        RouterLink,
        AngularSvgIconModule,
    ],
})
export class SignUpComponent implements OnInit {
  form!: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private http: HttpClient
    ) {
    
  }

  ngOnInit(): void {
    this.form = this.formBuilder.group({
      FirstName: '',
      LastName: '',
      Email: '',
      Password: '',
    });
  }

  submit(): void {
    // console.log(this.form.getRawValue());
    this.http.post("http://localhost:5050/auth/register", this.form.getRawValue(), { withCredentials: true })
      .subscribe(res =>{
        console.log(res)
      })
  }
}
