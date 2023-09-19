import { Injectable } from '@angular/core';
import { Student } from '../models/students.model';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StudentsService {
  
  baseApiUrl: string = 'https://localhost:7246';

  constructor(private http: HttpClient) { }

  getAllStudents(): Observable<Student[]>{
    return this.http.get<Student[]>(this.baseApiUrl + '/api/StudentRegistration');
  }

  addStudent(addStudentRequest: Student): Observable<Student>{
    addStudentRequest.StudentRegistrationId = 0;
    return this.http.post<Student>(this.baseApiUrl + '/api/StudentRegistration', 
    addStudentRequest);
  }

  getStudent(StudentRegistrationId: number): Observable<Student>{
    return this.http.get<Student>(this.baseApiUrl + '/api/StudentRegistration/' + StudentRegistrationId);
  }

  updateStudent(StudentRegistrationId: number, updateStudentRequest: Student):
  Observable<Student>{
    return this.http.put<Student>(this.baseApiUrl + '/api/StudentRegistration/' + StudentRegistrationId,
     updateStudentRequest);
  }

  deleteStudent(StudentRegistrationId: number): Observable<Student>{
    return this.http.delete<Student>(this.baseApiUrl + '/api/StudentRegistration/' + StudentRegistrationId);
  }



}
