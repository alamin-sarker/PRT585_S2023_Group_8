import { Component, OnInit } from '@angular/core';
import { StudentsService } from 'src/app/services/students.service';
import { Student } from 'src/app/models/students.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-student',
  templateUrl: './add-student.component.html',
  styleUrls: ['./add-student.component.css']
})
export class AddStudentComponent implements OnInit{

  addStudentRequest: Student = {
    StudentRegistrationId: 0,
    StudentName: '',
    PreferredName: '',
    StudentID: '',
    Course: '',
    CurrentSemester: 0,
    Email: '',
    PhoneNumber: 0,
    ReasonsToJoin: '',
    ExpectedOutcome: '',
    TimeAvailability: 1,
    PhotographyConsent: 1
  };


  constructor(private studentsService: StudentsService, 
    private router: Router){}

  ngOnInit(): void {
    
  }

  addStudent(){
    this.studentsService.addStudent(this.addStudentRequest)
    .subscribe({
      next: (student) => {
        this.router.navigate(['students']); 
        console.log(student);
      }
    });
  }

}
