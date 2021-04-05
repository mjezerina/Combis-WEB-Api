import { compilePipeFromMetadata } from '@angular/compiler';
import { Injectable } from '@angular/core';
import { ITS_JUST_ANGULAR } from '@angular/core/src/r3_symbols';
import { Contact } from './contacts.model';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class ContactsService {

  constructor(private http: HttpClient) { }

readonly baseURL = 'http://localhost:64973/api/Contacts'
formData:Contact = new Contact();

list: Contact[];

postContactDetails(){
  return this.http.post(this.baseURL,this.formData);
}

refreshList(){
  this.http.get(this.baseURL)
  .toPromise()
  .then(res => this.list = res as Contact[]);
}

getEmail(email: string){
  return this.http.get<any[]>(this.baseURL+"/email/"+email);
  }

}