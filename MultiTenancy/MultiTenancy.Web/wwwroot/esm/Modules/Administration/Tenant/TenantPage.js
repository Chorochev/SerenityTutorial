import{j as d,k as a,l as n,m as i}from"../../../_chunks/chunk-ZJRSMZTG.js";import{a as r,b as c,c as o,e as u,f as g}from"../../../_chunks/chunk-ZR7A2VZA.js";var l=c(g(),1);var s=c(u(),1);var m=c(u(),1);var e=class extends m.EntityDialog{constructor(){super(...arguments);this.form=new a(this.idPrefix)}getFormKey(){return a.formKey}getRowDefinition(){return n}getService(){return i.baseUrl}};r(e,"TenantDialog"),e=o([m.Decorators.registerClass("MultiTenancy.Administration.TenantDialog")],e);var t=class extends s.EntityGrid{getColumnsKey(){return d.columnsKey}getDialogType(){return e}getRowDefinition(){return n}getService(){return i.baseUrl}constructor(p){super(p)}};r(t,"TenantGrid"),t=o([s.Decorators.registerClass("MultiTenancy.Administration.TenantGrid")],t);function y(){(0,l.initFullHeightGridPage)(new t($("#GridDiv")).element)}r(y,"pageInit");export{y as default};
//# sourceMappingURL=TenantPage.js.map
