import { StringEditor, TextAreaEditor, IntegerEditor, DateEditor, LookupEditor, EnumEditor, PrefixedContext } from "@serenity-is/corelib";
import { GenreDialog } from "@/MovieDB/Genre/GenreDialog";
import { MovieKind } from "./MovieKind";
import { initFormType } from "@serenity-is/corelib/q";

export interface MovieForm {
    Title: StringEditor;
    Description: TextAreaEditor;
    Storyline: TextAreaEditor;
    Year: IntegerEditor;
    ReleaseDate: DateEditor;
    Runtime: IntegerEditor;
    GenreId: LookupEditor;
    Kind: EnumEditor;
}

export class MovieForm extends PrefixedContext {
    static formKey = 'MovieDB.Movie';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!MovieForm.init)  {
            MovieForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;
            var w2 = IntegerEditor;
            var w3 = DateEditor;
            var w4 = LookupEditor;
            var w5 = EnumEditor;

            initFormType(MovieForm, [
                'Title', w0,
                'Description', w1,
                'Storyline', w1,
                'Year', w2,
                'ReleaseDate', w3,
                'Runtime', w2,
                'GenreId', w4,
                'Kind', w5
            ]);
        }
    }
}

[GenreDialog, MovieKind]; // referenced types