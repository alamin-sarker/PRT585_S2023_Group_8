import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/models/students.model';
import { StudentsService } from 'src/app/services/students.service';
import { ActivatedRoute, Route, Router } from '@angular/router';

@Component({
  selector: 'app-edit-student',
  templateUrl: './edit-student.component.html',
  styleUrls: ['./edit-student.component.css']
})
export class EditStudentComponent implements OnInit{

  studentDetails: Student = {
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
  }
  
  constructor(private route: ActivatedRoute, private studentService: 
    StudentsService, private router: Router){ }
  
  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const StudentRegistrationId = Number(params.get('StudentRegistrationId'));

        if (StudentRegistrationId) {
          this.studentService.getStudent(StudentRegistrationId)
          .subscribe({
            next: (response) => {
              this.studentDetails = response;
            }
          })
        }
      }
    })
  }

  updateStudent(){
    this.studentService.updateStudent(this.studentDetails.StudentRegistrationId, this.studentDetails)
    .subscribe({
      next: (response) => {
        this.router.navigate(['students']);
      }
    });
  }

  deleteStudent(StudentRegistrationId: number){
    this.studentService.deleteStudent(StudentRegistrationId)
    .subscribe({
      next: (response) => {
        this.router.navigate(['students']);
      }
    })
  }

}
