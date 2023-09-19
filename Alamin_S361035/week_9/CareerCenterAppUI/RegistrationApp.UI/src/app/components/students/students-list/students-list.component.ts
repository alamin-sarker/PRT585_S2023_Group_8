import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/models/students.model';
import { StudentsService } from 'src/app/services/students.service';

@Component({
  selector: 'app-students-list',
  templateUrl: './students-list.component.html',
  styleUrls: ['./students-list.component.css']
})
export class StudentsListComponent implements OnInit{
  students: Student[] = [];
  constructor(private studentsService: StudentsService){ }
  ngOnInit(): void {
    //this.employees.push()
    this.studentsService.getAllStudents()
    .subscribe({
      next: (students) => {
        this.students = students;
        console.log(students);
      },
      error: (response) => {
        console.log(response);
      }
    })
  }

}
