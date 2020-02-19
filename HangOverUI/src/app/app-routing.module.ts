import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ValueComponent } from './value/value.component';


const routes: Routes = [
  {path: 'value', component: ValueComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
