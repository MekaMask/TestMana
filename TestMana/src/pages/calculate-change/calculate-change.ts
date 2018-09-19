import { CountMoney, GlobalVariable } from './../../app/models';
import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

/**
 * Generated class for the CalculateChangePage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-calculate-change',
  templateUrl: 'calculate-change.html',
})
export class CalculateChangePage {
  price : number ;
  pay : number;
  countM : CountMoney = new CountMoney;
  constructor(public navCtrl: NavController, public navParams: NavParams,public http: HttpClient) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad CalculateChangePage');
  }

  calculate() {
    this.http.get<CountMoney>(GlobalVariable.host + "api/Calculate/Pay/" + this.price + "/" + this.pay )
    .subscribe(data => {
      this.countM = data;
    });
  }

}
