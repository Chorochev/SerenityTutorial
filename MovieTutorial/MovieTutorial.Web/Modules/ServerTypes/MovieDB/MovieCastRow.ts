﻿import { fieldsProxy } from "@serenity-is/corelib/q";

export interface MovieCastRow {
    MovieCastId?: number;
    MovieId?: number;
    PersonId?: number;
    Character?: string;
    MovieTitle?: string;
    MovieYear?: number;
    PersonFirstName?: string;
    PersonLastname?: string;
    PersonFullname?: string;
}

export abstract class MovieCastRow {
    static readonly idProperty = 'MovieCastId';
    static readonly nameProperty = 'Character';
    static readonly localTextPrefix = 'MovieDB.MovieCast';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<MovieCastRow>();
}