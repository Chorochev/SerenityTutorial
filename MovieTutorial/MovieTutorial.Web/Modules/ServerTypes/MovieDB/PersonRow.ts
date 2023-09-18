import { Gender } from "./Gender";
import { fieldsProxy } from "@serenity-is/corelib/q";

export interface PersonRow {
    PersonId?: number;
    FirstName?: string;
    Lastname?: string;
    BirthDate?: string;
    BirthPlace?: string;
    Gender?: Gender;
    Height?: number;
}

export abstract class PersonRow {
    static readonly idProperty = 'PersonId';
    static readonly nameProperty = 'FirstName';
    static readonly localTextPrefix = 'MovieDB.Person';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<PersonRow>();
}