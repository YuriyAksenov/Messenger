import { Component, Input, Output, EventEmitter } from '@angular/core';

import { IContact } from '../../../shared/models/contact.model';
import { DisplayDirective } from '../../../shared/directives/display.directive';


@Component({
    moduleId: module.id,
    selector: 'contact-item',
    templateUrl: 'contact-item.component.html',
    styleUrls: ['contact-item.component.css']
})
export class ContactItemComponent {
    @Input() contact: IContact;

    @Output() checkContact = new EventEmitter<IContact>();
    @Output() mailContact = new EventEmitter<IContact>();
    @Output() phoneContact = new EventEmitter<IContact>();
    @Output() deleteContact = new EventEmitter<IContact>();


    //Отметить контакт
    onCheckContact(): void {
        this.checkContact.emit(this.contact);
    }

    onMailContact(){
        this.mailContact.emit(this.contact);
    }

    onPhoneContact(){
        this.phoneContact.emit(this.contact);
    }

    onDeleteContact(){
        this.deleteContact.emit(this.contact);
    }
    //TODO исправить посылку не весь объект а только его 
    //id  - то есть применить или отменить выбор данного объекта


}