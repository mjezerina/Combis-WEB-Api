import { Component, OnInit } from '@angular/core';
import { ContactsService } from '../shared/contacts.service';

@Component({
  selector: 'app-contacts',
  templateUrl: './contacts.component.html',
  styles: [
  ]
})
export class ContactsComponent implements OnInit {

  constructor(public service: ContactsService) { }

  ngOnInit(): void {
    this.service.refreshList();
  }

}
