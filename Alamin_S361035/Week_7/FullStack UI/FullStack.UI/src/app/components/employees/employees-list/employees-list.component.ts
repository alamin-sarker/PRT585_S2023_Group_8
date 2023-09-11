import { Component, OnInit } from '@angular/core';
import { EmployeesService } from 'src/app/Services/employees.service';
import { Employee } from 'src/app/models/employee.model';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.css']
})
export class EmployeesListComponent implements OnInit {

  employees: Employee[] = [];
  constructor(private employeesService: EmployeesService){ }
  ngOnInit(): void {
    //this.employees.push()
    this.employeesService.getAllEmployees()
    .subscribe({
      next: (employees) => {
        this.employees = employees;
      },
      error: (response) => {
        console.log(response);
      }
    })
  }
  }
  

 
