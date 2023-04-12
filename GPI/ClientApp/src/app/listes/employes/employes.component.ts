import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-employes',
  templateUrl: './employes.component.html',
  styleUrls: ['./employes.component.css']
})

export class EmployesComponent {
  public employees: Employee[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Employee[]>(baseUrl + 'api/Emplyee/getAll').subscribe(result => {
      this.employees = result;
    }, error => console.error(error));
  }
}

interface Employee {
  nom: string;
  prenom: string;
  mail: string;
  role: string;

}
