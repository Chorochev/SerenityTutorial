import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TenantGrid } from './TenantGrid';

export default function pageInit() {
    initFullHeightGridPage(new TenantGrid($('#GridDiv')).element);
}