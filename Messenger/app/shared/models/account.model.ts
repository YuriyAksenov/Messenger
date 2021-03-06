export interface IAccount {
    id: number;
    choosen: boolean;
    matched: boolean;
    firstName: string;
    lastName: string;
    birthdate: Date;
    sex: string;
    phone: string;
    password: string;
    email: string;
}

export class Account implements IAccount {
    id: number;
    choosen: boolean = false;
    matched: boolean = true;
    constructor(
        public password: string,
        public firstName: string = '',
        public lastName: string = '',
        public birthdate: Date = null,
        public sex: string = 'any',
        public phone: string = '',
        public email: string = '') { }
}