import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TenantForm, TenantRow, TenantService } from '@/ServerTypes/Administration';

@Decorators.registerClass('MultiTenancy.Administration.TenantDialog')
export class TenantDialog extends EntityDialog<TenantRow, any> {
    protected getFormKey() { return TenantForm.formKey; }
    protected getRowDefinition() { return TenantRow; }
    protected getService() { return TenantService.baseUrl; }

    protected form = new TenantForm(this.idPrefix);
}