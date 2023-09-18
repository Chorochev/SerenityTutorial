import { StringEditor, DateEditor, EnumEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { Gender } from "./Gender";
import { initFormType } from "@serenity-is/corelib/q";

export interface PersonForm {
    FirstName: StringEditor;
    Lastname: StringEditor;
    BirthDate: DateEditor;
    BirthPlace: StringEditor;
    Gender: EnumEditor;
    Height: IntegerEditor;
}

export class PersonForm extends PrefixedContext {
    static formKey = 'MovieDB.Person';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PersonForm.init)  {
            PersonForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = EnumEditor;
            var w3 = IntegerEditor;

            initFormType(PersonForm, [
                'FirstName', w0,
                'Lastname', w0,
                'BirthDate', w1,
                'BirthPlace', w0,
                'Gender', w2,
                'Height', w3
            ]);
        }
    }
}

[Gender]; // referenced types