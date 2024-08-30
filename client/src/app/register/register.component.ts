import { Component, input } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {
  usersFromHomeComponent = input.required<any>(); //This is used when parent want to pass a property to a child component
  model: any = {
  }

  register() {
    console.log(this.model);
  }

  cancel() {
    console.log('cancelled');
  }
}
