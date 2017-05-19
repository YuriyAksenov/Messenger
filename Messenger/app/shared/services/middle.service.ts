import { Injectable, OnDestroy } from '@angular/core';
import { AppService } from "./app.service";
import { Observable } from 'rxjs/Observable';
import { Subscription }   from 'rxjs/Subscription';
import { Subject }   from 'rxjs/Subject';
//import 'rxjs/add/operator/fromPromise';
// import 'rxjs/add/operator/catch';
// import 'rxjs/add/observable/throw';
import 'rxjs/Rx';


import { Contact } from '../models/contact.model';
import { Account } from '../models/account.model';

@Injectable()
export class MiddleService implements OnDestroy{

    middleScreen = new Subject<MiddleScreen>()
    middleScreen$ = this.middleScreen.asObservable();

    constructor(private appService: AppService) {
        this.middleScreen.subscribe(middleScreenState =>
        {
            this.middleScreen = middleScreenState;
        })
    }

    getContacts(): Observable<Contact[]> {
        return Observable.from<Contact[]>(
            this.appService.getContacts()
                .map(contacts => {
                    //this.contacts = contacts;
                    //this.contactsSort();
                    return contacts;
                }
                )
        )

    }

    getAccount(id: number): Observable<Account> {
        return Observable.from(
            this.appService.getAccount(id)
                .map(account => { return account; }));
    }

    ngOnDestroy(){
        this.middleScreenSubscriptin.unsubscribe();
    }

    

}