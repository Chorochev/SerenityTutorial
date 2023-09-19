import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { MovieCastGrid } from './MovieCastGrid';

export default function pageInit() {
    initFullHeightGridPage(new MovieCastGrid($('#GridDiv')).element);
}