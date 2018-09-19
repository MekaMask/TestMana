import { CalculateChangePage } from './../calculate-change/calculate-change';
import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { CalculateNumberPage } from '../calculate-number/calculate-number';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  constructor(public navCtrl: NavController) {

  }

  calculateNumber () {
    this.navCtrl.push(CalculateNumberPage)
  }
  calculateChange () {
    this.navCtrl.push(CalculateChangePage);
  }

}
