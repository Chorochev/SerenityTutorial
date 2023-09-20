import { Decorators, EntityGrid, QuickSearchField } from '@serenity-is/corelib';
import { MovieColumns, MovieRow, MovieService } from '@/ServerTypes/MovieDB';
import { MovieDialog } from './MovieDialog';

@Decorators.registerClass('MovieTutorial.MovieDB.MovieGrid')
export class MovieGrid extends EntityGrid<MovieRow, any> {
    protected getColumnsKey() { return MovieColumns.columnsKey; }
    protected getDialogType() { return MovieDialog; }
    protected getRowDefinition() { return MovieRow; }
    protected getService() { return MovieService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getQuickSearchFields(): QuickSearchField[] {
        const fld = MovieRow.Fields;
        return [
            { name: "", title: "all" },
            { name: fld.Description, title: "description" },
            { name: fld.Storyline, title: "storyline" },
            { name: fld.Year, title: "year" }
        ];
    }

}