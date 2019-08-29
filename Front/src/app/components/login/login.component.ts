import { Component, OnInit } from '@angular/core';
import { UserControlService } from 'src/app/services/userControl.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
  providers: [UserControlService]
})
export class LoginComponent implements OnInit {

  constructor(private _userControlService:UserControlService) { }

  ngOnInit() {
    this._userControlService.getUsersById(1).subscribe(res=>{
      console.log(res);
    })
  }
  
}
