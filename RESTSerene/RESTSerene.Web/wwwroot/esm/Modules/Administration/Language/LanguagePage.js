import{a as u,b as m,c as e,d as i}from"../../../_chunks/chunk-2DKJX6BK.js";import{a as o,b as c,c as n,e as s,f as l}from"../../../_chunks/chunk-ZR7A2VZA.js";var d=c(l(),1);var a=c(s(),1);var r=class extends a.EntityDialog{constructor(){super(...arguments);this.form=new m(this.idPrefix)}getFormKey(){return m.formKey}getIdProperty(){return e.idProperty}getLocalTextPrefix(){return e.localTextPrefix}getNameProperty(){return e.nameProperty}getService(){return i.baseUrl}};o(r,"LanguageDialog"),r=n([a.Decorators.registerClass("RESTSerene.Administration.LanguageDialog")],r);var p=c(s(),1);var t=class extends p.EntityGrid{useAsync(){return!0}getColumnsKey(){return u.columnsKey}getDialogType(){return r}getIdProperty(){return e.idProperty}getLocalTextPrefix(){return e.localTextPrefix}getService(){return i.baseUrl}afterInit(){super.afterInit()}getDefaultSortBy(){return[e.Fields.LanguageName]}};o(t,"LanguageGrid"),t=n([p.Decorators.registerClass("RESTSerene.Administration.LanguageGrid")],t);$(function(){(0,d.initFullHeightGridPage)(new t($("#GridDiv")).element)});
//# sourceMappingURL=LanguagePage.js.map
