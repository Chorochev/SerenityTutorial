import{a as U}from"../../../_chunks/chunk-UI6TKAI2.js";import{h as x,k as C,l as w,m as g,n as e,o as h}from"../../../_chunks/chunk-LRHX53QA.js";import{a as f}from"../../../_chunks/chunk-SNAIRMRA.js";import{a,c as o,d as p,f as c,g as y}from"../../../_chunks/chunk-ZGHGXMHT.js";var R=o(c(),1);var P=o(y(),1),b=o(c(),1);var I=o(y(),1),t=o(c(),1);var d=class extends I.TemplatedDialog{constructor(r){super(r);this.permissions=new U(this.byId("Permissions"),{showRevoke:!0}),g.List({UserID:this.options.userID,Module:null,Submodule:null},s=>{this.permissions.value=s.Entities}),g.ListRolePermissions({UserID:this.options.userID,Module:null,Submodule:null},s=>{this.permissions.rolePermissions=s.Entities}),this.permissions.implicitPermissions=(0,t.getRemoteData)("Administration.ImplicitPermissions"),this.dialogTitle=(0,t.format)((0,t.localText)("Site.UserPermissionDialog.DialogTitle"),this.options.username)}getDialogButtons(){return[{text:(0,t.localText)("Dialogs.OkButton"),cssClass:"btn btn-primary",click:r=>{g.Update({UserID:this.options.userID,Permissions:this.permissions.value,Module:null,Submodule:null},s=>{this.dialogClose(),window.setTimeout(()=>(0,t.notifySuccess)((0,t.localText)("Site.UserPermissionDialog.SaveSuccess")),0)})}},{text:(0,t.localText)("Dialogs.CancelButton"),click:()=>this.dialogClose()}]}getTemplate(){return'<div id="~_Permissions"></div>'}};a(d,"UserPermissionDialog");var u=o(y(),1),m=o(c(),1);var i=class extends u.EntityDialog{constructor(){super();this.form=new w(this.idPrefix);this.form.Password.change(()=>{u.EditorUtils.setRequired(this.form.PasswordConfirm,this.form.Password.value.length>0)}),this.form.Password.addValidationRule(this.uniqueName,r=>{if(this.form.Password.value.length<6)return(0,m.format)((0,m.localText)(f.Validation.MinRequiredPasswordLength),6)}),this.form.PasswordConfirm.addValidationRule(this.uniqueName,r=>{if(this.form.Password.value!=this.form.PasswordConfirm.value)return(0,m.localText)(f.Validation.PasswordConfirmMismatch)})}getFormKey(){return w.formKey}getIdProperty(){return e.idProperty}getIsActiveProperty(){return e.isActiveProperty}getLocalTextPrefix(){return e.localTextPrefix}getNameProperty(){return e.nameProperty}getService(){return h.baseUrl}getToolbarButtons(){let r=super.getToolbarButtons();return r.push({title:(0,m.localText)(f.Site.UserDialog.EditPermissionsButton),cssClass:"edit-permissions-button",icon:"fa-lock text-green",onClick:()=>{new d({userID:this.entity.UserId,username:this.entity.Username}).dialogOpen()}}),r}updateInterface(){super.updateInterface(),this.toolbar.findButton("edit-permissions-button").toggleClass("disabled",this.isNewOrDeleted())}afterLoadEntity(){super.afterLoadEntity(),this.form.Password.element.toggleClass("required",this.isNew()).closest(".field").find("sup").toggle(this.isNew()),this.form.PasswordConfirm.element.toggleClass("required",this.isNew()).closest(".field").find("sup").toggle(this.isNew())}};a(i,"UserDialog"),i=p([u.Decorators.registerClass()],i);var n=class extends P.EntityGrid{getColumnsKey(){return C.columnsKey}getDialogType(){return i}getIdProperty(){return e.idProperty}getIsActiveProperty(){return e.isActiveProperty}getLocalTextPrefix(){return e.localTextPrefix}getService(){return h.baseUrl}constructor(l){super(l)}getDefaultSortBy(){return[e.Fields.Username]}getColumns(){var l=super.getColumns(),r=(0,b.tryFirst)(l,s=>s.field==e.Fields.Roles);return r&&(r.format=s=>{var D=(s.value||[]).map(S=>(x.getLookup().itemById[S]||{}).RoleName||"");return D.sort(),D.join(", ")}),l}};a(n,"UserGrid"),n=p([P.Decorators.registerClass()],n);$(function(){(0,R.initFullHeightGridPage)(new n($("#GridDiv")).element)});
//# sourceMappingURL=UserPage.js.map
