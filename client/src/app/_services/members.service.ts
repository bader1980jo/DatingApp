import { Member } from 'src/app/_models/Member';

import { Observable } from 'rxjs';
import { environment } from './../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class MembersService {
  baseUrl = environment.apuUrl;
 
  constructor(private http: HttpClient) { }

  getMembers() 
  {
    return this.http.get<Member[]>(this.baseUrl + 'users');
  }

  getMember(username: string){
    return this.http.get<Member>(this.baseUrl + 'users/'+ username);
  }
}
