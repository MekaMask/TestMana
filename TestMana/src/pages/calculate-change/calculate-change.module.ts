import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { CalculateChangePage } from './calculate-change';

@NgModule({
  declarations: [
    CalculateChangePage,
  ],
  imports: [
    IonicPageModule.forChild(CalculateChangePage),
  ],
})
export class CalculateChangePageModule {}
