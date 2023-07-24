import { Component, OnInit } from '@angular/core';
import { Todo } from 'src/app/models/todo.model';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent {
  todos: Todo[]= [
    {
      id: 1,
      name: 'Titles arfe in H1 tags',
      activitiy: 'H1 tags are used in the list title',
      date: "12/02/2010",
      days: 3
    },
    {
      id: 2,
      name: 'Paragraphs arfe in P tags',
      activitiy: 'P tags are used in the list title',
      date: "12/02/2020",
      days: 3
    },
    {
      id: 3,
      name: 'Titles arfe in H5 tags',
      activitiy: 'H5 tags are used in the list title',
      date: "12/02/2030",
      days: 3
    }
  ];
  constructor (){}
  ngOnInit(): void{};

}
