import { fieldsProxy } from "@serenity-is/corelib/q";

export interface TenantRow {
    TenantId?: number;
    TenantName?: string;
}

export abstract class TenantRow {
    static readonly idProperty = 'TenantId';
    static readonly nameProperty = 'TenantName';
    static readonly localTextPrefix = 'Administration.Tenant';
    static readonly deletePermission = 'Administration:Tenants';
    static readonly insertPermission = 'Administration:Tenants';
    static readonly readPermission = 'Administration:Tenants';
    static readonly updatePermission = 'Administration:Tenants';

    static readonly Fields = fieldsProxy<TenantRow>();
}