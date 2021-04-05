import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Contact } from 'src/app/shared/contacts.model';
import { ContactsService } from 'src/app/shared/contacts.service';

@Component({
  selector: 'app-contacts-form',
  templateUrl: './contacts-form.component.html',
  styles: [
  ]
})
export class ContactsFormComponent implements OnInit {

  constructor(public service: ContactsService, private toastr: ToastrService) { }

  ngOnInit(): void {
  }


  OnSubmit(form: NgForm) {
    this.service.postContactDetails().subscribe(
      res => {
        this.resetForm(form);
        this.toastr.success('Submitted', 'Unos novog kontakta');
      },
      err => { console.log(err) }
    );
  }



  resetForm(form: NgForm) {
    form.form.reset();
    this.service.formData = new Contact();
    this.service.refreshList();
  }

}
