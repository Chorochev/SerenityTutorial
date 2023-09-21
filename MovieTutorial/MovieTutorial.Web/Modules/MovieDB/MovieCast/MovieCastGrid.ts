import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { MovieCastColumns, MovieCastRow, MovieCastService } from '@/ServerTypes/MovieDB';
import { MovieCastDialog } from './MovieCastDialog';

@Decorators.registerClass('MovieTutorial.MovieDB.MovieCastGrid')
export class MovieCastGrid extends EntityGrid<MovieCastRow, any> {
    protected getColumnsKey() { return MovieCastColumns.columnsKey; }
    protected getDialogType() { return MovieCastDialog; }
    protected getRowDefinition() { return MovieCastRow; }
    protected getService() { return MovieCastService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}