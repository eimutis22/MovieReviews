import { Component } from '@angular/core';
import { TestComponent } from './TestComponent/test.component';

@Component({
    selector: 'my-app',
    templateUrl: './app.component.html'
  //template: `<h1>Hello {{name}}!</h1>
  //          <my-test-component></my-test-component>`,
})
export class AppComponent  {
    name = 'App Component';
}
