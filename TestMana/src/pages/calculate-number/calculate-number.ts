import { GlobalVariable } from './../../app/models';
import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';


/**
 * Generated class for the CalculateNumberPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-calculate-number',
  templateUrl: 'calculate-number.html',
})
export class CalculateNumberPage {

  num1 : number;
  num2  : number;
  result : any;
  constructor(public navCtrl: NavController, public navParams: NavParams,public http: HttpClient) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad CalculateNumberPage');
  }

  Plus() {
  //  this.result = Number(this.num1) + Number(this.num2);
   this.http.get(GlobalVariable.host + "api/Calculate/Add/" + this.num1 + "/" + this.num2)
   .subscribe(data => {
     console.log(data);
     
     this.result = data;

   });
  }

  Minus() {
    this.http.get(GlobalVariable.host + "api/Calculate/Minus/" + this.num1 + "/" + this.num2)
   .subscribe(data => {
     this.result = data;

   });
  }

  Multiple() {
    this.http.get(GlobalVariable.host + "api/Calculate/multiple/" + this.num1 + "/" + this.num2)
    .subscribe(data => {
      this.result = data;
 
    });
  }

  Devide() {
    this.http.get(GlobalVariable.host + "api/Calculate/Devide/" + this.num1 + "/" + this.num2)
   .subscribe(data => {
     this.result = data;

   });
  }

}
