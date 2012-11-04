﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.269.
// 
#pragma warning disable 1591

namespace SuperSimpleSync.SyncServer {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SyncSoap", Namespace="http://tempuri.org/")]
    public partial class Sync : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetFileFromServerOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendFileToServerOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetServerSyncDirOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Sync() {
            this.Url = global::SuperSimpleSync.Properties.Settings.Default.SuperSimpleSync_SyncServer_Sync;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetFileFromServerCompletedEventHandler GetFileFromServerCompleted;
        
        /// <remarks/>
        public event SendFileToServerCompletedEventHandler SendFileToServerCompleted;
        
        /// <remarks/>
        public event GetServerSyncDirCompletedEventHandler GetServerSyncDirCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetFileFromServer", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] GetFileFromServer(System.Guid accountId, string path) {
            object[] results = this.Invoke("GetFileFromServer", new object[] {
                        accountId,
                        path});
            return ((byte[])(results[0]));
        }
        
        /// <remarks/>
        public void GetFileFromServerAsync(System.Guid accountId, string path) {
            this.GetFileFromServerAsync(accountId, path, null);
        }
        
        /// <remarks/>
        public void GetFileFromServerAsync(System.Guid accountId, string path, object userState) {
            if ((this.GetFileFromServerOperationCompleted == null)) {
                this.GetFileFromServerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFileFromServerOperationCompleted);
            }
            this.InvokeAsync("GetFileFromServer", new object[] {
                        accountId,
                        path}, this.GetFileFromServerOperationCompleted, userState);
        }
        
        private void OnGetFileFromServerOperationCompleted(object arg) {
            if ((this.GetFileFromServerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFileFromServerCompleted(this, new GetFileFromServerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendFileToServer", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SendFileToServer(System.Guid accountId, string path, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] buffer) {
            this.Invoke("SendFileToServer", new object[] {
                        accountId,
                        path,
                        buffer});
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/appendLine", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void appendLine(System.Guid accountId,string line)
        {
            this.Invoke("appendLine", new object[] {
                        accountId,line});
        }
        
        /// <remarks/>
        public void SendFileToServerAsync(System.Guid accountId, string path, byte[] buffer) {
            this.SendFileToServerAsync(accountId, path, buffer, null);
        }
        
        /// <remarks/>
        public void SendFileToServerAsync(System.Guid accountId, string path, byte[] buffer, object userState) {
            if ((this.SendFileToServerOperationCompleted == null)) {
                this.SendFileToServerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendFileToServerOperationCompleted);
            }
            this.InvokeAsync("SendFileToServer", new object[] {
                        accountId,
                        path,
                        buffer}, this.SendFileToServerOperationCompleted, userState);
        }
        
        private void OnSendFileToServerOperationCompleted(object arg) {
            if ((this.SendFileToServerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendFileToServerCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetServerSyncDir", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetServerSyncDir(System.Guid accountId, string rootDir) {
            object[] results = this.Invoke("GetServerSyncDir", new object[] {
                        accountId,
                        rootDir});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetServerSyncDirAsync(System.Guid accountId, string rootDir) {
            this.GetServerSyncDirAsync(accountId, rootDir, null);
        }
        
        /// <remarks/>
        public void GetServerSyncDirAsync(System.Guid accountId, string rootDir, object userState) {
            if ((this.GetServerSyncDirOperationCompleted == null)) {
                this.GetServerSyncDirOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetServerSyncDirOperationCompleted);
            }
            this.InvokeAsync("GetServerSyncDir", new object[] {
                        accountId,
                        rootDir}, this.GetServerSyncDirOperationCompleted, userState);
        }
        
        private void OnGetServerSyncDirOperationCompleted(object arg) {
            if ((this.GetServerSyncDirCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetServerSyncDirCompleted(this, new GetServerSyncDirCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetFileFromServerCompletedEventHandler(object sender, GetFileFromServerCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFileFromServerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFileFromServerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public byte[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void SendFileToServerCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetServerSyncDirCompletedEventHandler(object sender, GetServerSyncDirCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetServerSyncDirCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetServerSyncDirCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591