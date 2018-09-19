import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { CalculateNumberPage } from './calculate-number';

@NgModule({
  declarations: [
    CalculateNumberPage,
  ],
  imports: [
    IonicPageModule.forChild(CalculateNumberPage),
  ],
})
export class CalculateNumberPageModule {}
