import{q as u,r as c,s as e,t as n}from"../../../_chunks/chunk-2VNNZIPS.js";import{a as o,c as m,d as i,f as P,g as a}from"../../../_chunks/chunk-ZGHGXMHT.js";var l=m(P(),1);var p=m(a(),1);var s=m(a(),1);var r=class extends s.EntityDialog{constructor(){super(...arguments);this.form=new c(this.idPrefix)}getFormKey(){return c.formKey}getIdProperty(){return e.idProperty}getLocalTextPrefix(){return e.localTextPrefix}getNameProperty(){return e.nameProperty}getService(){return n.baseUrl}getDeletePermission(){return e.deletePermission}getInsertPermission(){return e.insertPermission}getUpdatePermission(){return e.updatePermission}afterLoadEntity(){super.afterLoadEntity(),this.form.MoviesGrid.personID=this.entityId}};o(r,"PersonDialog"),r=i([s.Decorators.registerClass("MovieTutorial.MovieDB.PersonDialog")],r);var t=class extends p.EntityGrid{getColumnsKey(){return u.columnsKey}getDialogType(){return r}getRowDefinition(){return e}getService(){return n.baseUrl}constructor(d){super(d)}};o(t,"PersonGrid"),t=i([p.Decorators.registerClass("MovieTutorial.MovieDB.PersonGrid")],t);function g(){(0,l.initFullHeightGridPage)(new t($("#GridDiv")).element)}o(g,"pageInit");export{g as default};
//# sourceMappingURL=PersonPage.js.map
