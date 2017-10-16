﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 14.0.23107.0
// 
namespace App1.ServiceReference1 {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/EmployeeWebserviceREST")]
    public partial class Employee : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int empIDField;
        
        private string firstNameField;
        
        private string lastNameField;
        
        private System.Nullable<int> AgeField;
        
        private string addressField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int empID {
            get {
                return this.empIDField;
            }
            set {
                if ((this.empIDField.Equals(value) != true)) {
                    this.empIDField = value;
                    this.RaisePropertyChanged("empID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.firstNameField, value) != true)) {
                    this.firstNameField = value;
                    this.RaisePropertyChanged("firstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.lastNameField, value) != true)) {
                    this.lastNameField = value;
                    this.RaisePropertyChanged("lastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public System.Nullable<int> Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IEmployee")]
    public interface IEmployee {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployee/GetProductList", ReplyAction="http://tempuri.org/IEmployee/GetProductListResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<App1.ServiceReference1.Employee>> GetProductListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployee/AddEmployee", ReplyAction="http://tempuri.org/IEmployee/AddEmployeeResponse")]
        System.Threading.Tasks.Task<bool> AddEmployeeAsync(App1.ServiceReference1.Employee eml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployee/UpdateEmployee", ReplyAction="http://tempuri.org/IEmployee/UpdateEmployeeResponse")]
        System.Threading.Tasks.Task<bool> UpdateEmployeeAsync(App1.ServiceReference1.Employee eml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployee/DeleteEmployee", ReplyAction="http://tempuri.org/IEmployee/DeleteEmployeeResponse")]
        System.Threading.Tasks.Task<bool> DeleteEmployeeAsync(int idE);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeChannel : App1.ServiceReference1.IEmployee, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeClient : System.ServiceModel.ClientBase<App1.ServiceReference1.IEmployee>, App1.ServiceReference1.IEmployee {
        
        public EmployeeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<App1.ServiceReference1.Employee>> GetProductListAsync() {
            return base.Channel.GetProductListAsync();
        }
        
        public System.Threading.Tasks.Task<bool> AddEmployeeAsync(App1.ServiceReference1.Employee eml) {
            return base.Channel.AddEmployeeAsync(eml);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateEmployeeAsync(App1.ServiceReference1.Employee eml) {
            return base.Channel.UpdateEmployeeAsync(eml);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteEmployeeAsync(int idE) {
            return base.Channel.DeleteEmployeeAsync(idE);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
    }
}
