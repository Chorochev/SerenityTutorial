import{a as s,b as u,c as e,d as n}from"../../../_chunks/chunk-BGX5KIY6.js";import{a as o,b as c,c as i,e as m,f as l}from"../../../_chunks/chunk-ZR7A2VZA.js";var d=c(l(),1);var a=c(m(),1);var r=class extends a.EntityDialog{constructor(){super(...arguments);this.form=new u(this.idPrefix)}getFormKey(){return u.formKey}getIdProperty(){return e.idProperty}getLocalTextPrefix(){return e.localTextPrefix}getNameProperty(){return e.nameProperty}getService(){return n.baseUrl}};o(r,"LanguageDialog"),r=i([a.Decorators.registerClass("MovieTutorial.Administration.LanguageDialog")],r);var p=c(m(),1);var t=class extends p.EntityGrid{useAsync(){return!0}getColumnsKey(){return s.columnsKey}getDialogType(){return r}getIdProperty(){return e.idProperty}getLocalTextPrefix(){return e.localTextPrefix}getService(){return n.baseUrl}afterInit(){super.afterInit()}getDefaultSortBy(){return[e.Fields.LanguageName]}};o(t,"LanguageGrid"),t=i([p.Decorators.registerClass("MovieTutorial.Administration.LanguageGrid")],t);$(function(){(0,d.initFullHeightGridPage)(new t($("#GridDiv")).element)});
//# sourceMappingURL=LanguagePage.js.map
