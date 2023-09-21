import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TenantColumns, TenantRow, TenantService } from '@/ServerTypes/Administration';
import { TenantDialog } from './TenantDialog';

@Decorators.registerClass('MultiTenancy.Administration.TenantGrid')
export class TenantGrid extends EntityGrid<TenantRow, any> {
    protected getColumnsKey() { return TenantColumns.columnsKey; }
    protected getDialogType() { return TenantDialog; }
    protected getRowDefinition() { return TenantRow; }
    protected getService() { return TenantService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}