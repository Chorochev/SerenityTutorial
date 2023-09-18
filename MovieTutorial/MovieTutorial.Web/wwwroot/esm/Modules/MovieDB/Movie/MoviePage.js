import{a as t,b as o,c as y,e as R,f as S}from"../../../_chunks/chunk-5RSNY2PG.js";var E=o(R(),1);var D=o(S(),1);var c=class{};t(c,"MovieColumns"),c.columnsKey="MovieDB.Movie";var r=o(S(),1),g=o(R(),1);var m=class extends r.PrefixedContext{constructor(i){if(super(i),!m.init){m.init=!0;var p=r.StringEditor,u=r.TextAreaEditor,v=r.IntegerEditor,x=r.DateEditor;(0,g.initFormType)(m,["Title",p,"Description",u,"Storyline",u,"Year",v,"ReleaseDate",x,"Runtime",v])}}},s=m;t(s,"MovieForm"),s.formKey="MovieDB.Movie";var M=o(R(),1);var e=class{};t(e,"MovieRow"),e.idProperty="MovieId",e.nameProperty="Title",e.localTextPrefix="MovieDB.Movie",e.deletePermission="Administration:General",e.insertPermission="Administration:General",e.readPermission="Administration:General",e.updatePermission="Administration:General",e.Fields=(0,M.fieldsProxy)();var q=o(R(),1),l;(p=>(p.baseUrl="MovieDB/Movie",p.Methods={Create:"MovieDB/Movie/Create",Update:"MovieDB/Movie/Update",Delete:"MovieDB/Movie/Delete",Retrieve:"MovieDB/Movie/Retrieve",List:"MovieDB/Movie/List"},["Create","Update","Delete","Retrieve","List"].forEach(u=>{p[u]=function(v,x,T){return(0,q.serviceRequest)(p.baseUrl+"/"+u,v,x,T)}})))(l||(l={}));var f=o(S(),1);var n=class extends f.EntityDialog{constructor(){super(...arguments);this.form=new s(this.idPrefix)}getFormKey(){return s.formKey}getRowDefinition(){return e}getService(){return l.baseUrl}};t(n,"MovieDialog"),n=y([f.Decorators.registerClass("MovieTutorial.MovieDB.MovieDialog")],n);var a=class extends D.EntityGrid{getColumnsKey(){return c.columnsKey}getDialogType(){return n}getRowDefinition(){return e}getService(){return l.baseUrl}constructor(i){super(i)}getQuickSearchFields(){let i=e.Fields;return[{name:"",title:"all"},{name:i.Description,title:"description"},{name:i.Storyline,title:"storyline"},{name:i.Year,title:"year"}]}};t(a,"MovieGrid"),a=y([D.Decorators.registerClass("MovieTutorial.MovieDB.MovieGrid")],a);function B(){(0,E.initFullHeightGridPage)(new a($("#GridDiv")).element)}t(B,"pageInit");export{B as default};
//# sourceMappingURL=MoviePage.js.map
