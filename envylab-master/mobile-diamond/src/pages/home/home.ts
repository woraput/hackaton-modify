import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { GlobalVarible } from '../../app/models';
import { HttpClient, HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {


  number: number;

  constructor(public navCtrl: NavController, public http: HttpClient) {

  }


  CheckNumber() {
    this.http.get(GlobalVarible.host + "api/Values/GetConcusitive/" + this.number)
      .subscribe(data => {
        
      });
  }
}
