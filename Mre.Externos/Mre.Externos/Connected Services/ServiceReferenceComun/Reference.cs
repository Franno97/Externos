﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mre.Externos.ServiceReferenceComun {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntidadAuspicianteCentroAdministrativo", Namespace="http://schemas.datacontract.org/2004/07/Mre.Sicof.CuentasConsulares.Business.Enti" +
        "ty")]
    [System.SerializableAttribute()]
    public partial class EntidadAuspicianteCentroAdministrativo : Mre.Externos.ServiceReferenceComun.EntidadAuspicianteCentroAdministrativoBase {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntidadAuspicianteCentroAdministrativoBase", Namespace="http://schemas.datacontract.org/2004/07/Mre.Sicof.CuentasConsulares.Business.Enti" +
        "ty")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Mre.Externos.ServiceReferenceComun.EntidadAuspicianteCentroAdministrativo))]
    public partial class EntidadAuspicianteCentroAdministrativoBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdEntidadAuspicianteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdEntidadAuspiciante {
            get {
                return this.IdEntidadAuspicianteField;
            }
            set {
                if ((this.IdEntidadAuspicianteField.Equals(value) != true)) {
                    this.IdEntidadAuspicianteField = value;
                    this.RaisePropertyChanged("IdEntidadAuspiciante");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ObtenerActividadesPorTipoVisa_Result", Namespace="http://schemas.datacontract.org/2004/07/MREMH.ServiciosEsigexVisasRegularizacion." +
        "Logica.ReferenciaMantenimientosAsuntosMigratoriosWs")]
    [System.SerializableAttribute()]
    public partial class ObtenerActividadesPorTipoVisa_Result : Mre.Externos.ServiceReferenceComun.ComplexObject {
        
        private int idFieldField;
        
        private string nombreFieldField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int idField {
            get {
                return this.idFieldField;
            }
            set {
                if ((this.idFieldField.Equals(value) != true)) {
                    this.idFieldField = value;
                    this.RaisePropertyChanged("idField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string nombreField {
            get {
                return this.nombreFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreFieldField, value) != true)) {
                    this.nombreFieldField = value;
                    this.RaisePropertyChanged("nombreField");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StructuralObject", Namespace="http://schemas.datacontract.org/2004/07/MREMH.ServiciosEsigexVisasRegularizacion." +
        "Logica.ReferenciaMantenimientosAsuntosMigratoriosWs")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Mre.Externos.ServiceReferenceComun.ComplexObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Mre.Externos.ServiceReferenceComun.ObtenerActividadesPorTipoVisa_Result))]
    public partial class StructuralObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ComplexObject", Namespace="http://schemas.datacontract.org/2004/07/MREMH.ServiciosEsigexVisasRegularizacion." +
        "Logica.ReferenciaMantenimientosAsuntosMigratoriosWs")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Mre.Externos.ServiceReferenceComun.ObtenerActividadesPorTipoVisa_Result))]
    public partial class ComplexObject : Mre.Externos.ServiceReferenceComun.StructuralObject {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Requisito", Namespace="http://schemas.datacontract.org/2004/07/Mre.Sicof.CuentasConsulares.Business.Enti" +
        "ty")]
    [System.SerializableAttribute()]
    public partial class Requisito : Mre.Externos.ServiceReferenceComun.RequisitoBase {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityBaseCore", Namespace="http://schemas.datacontract.org/2004/07/Mre.Sicof.CuentasConsulares.Business.Enti" +
        "ty")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Mre.Externos.ServiceReferenceComun.EntityBase))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Mre.Externos.ServiceReferenceComun.RequisitoBase))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Mre.Externos.ServiceReferenceComun.Requisito))]
    public partial class EntityBaseCore : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Mre.Externos.ServiceReferenceComun.EntityState EntityStateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Mre.Externos.ServiceReferenceComun.EntityState EntityState {
            get {
                return this.EntityStateField;
            }
            set {
                if ((this.EntityStateField.Equals(value) != true)) {
                    this.EntityStateField = value;
                    this.RaisePropertyChanged("EntityState");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityBase", Namespace="http://schemas.datacontract.org/2004/07/Mre.Sicof.CuentasConsulares.Business.Enti" +
        "ty")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Mre.Externos.ServiceReferenceComun.RequisitoBase))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Mre.Externos.ServiceReferenceComun.Requisito))]
    public partial class EntityBase : Mre.Externos.ServiceReferenceComun.EntityBaseCore {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RequisitoBase", Namespace="http://schemas.datacontract.org/2004/07/Mre.Sicof.CuentasConsulares.Business.Enti" +
        "ty")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Mre.Externos.ServiceReferenceComun.Requisito))]
    public partial class RequisitoBase : Mre.Externos.ServiceReferenceComun.EntityBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EntidadActivaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdActoConsularField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdRequisitoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] VersionFilaField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool EntidadActiva {
            get {
                return this.EntidadActivaField;
            }
            set {
                if ((this.EntidadActivaField.Equals(value) != true)) {
                    this.EntidadActivaField = value;
                    this.RaisePropertyChanged("EntidadActiva");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdActoConsular {
            get {
                return this.IdActoConsularField;
            }
            set {
                if ((this.IdActoConsularField.Equals(value) != true)) {
                    this.IdActoConsularField = value;
                    this.RaisePropertyChanged("IdActoConsular");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdRequisito {
            get {
                return this.IdRequisitoField;
            }
            set {
                if ((this.IdRequisitoField.Equals(value) != true)) {
                    this.IdRequisitoField = value;
                    this.RaisePropertyChanged("IdRequisito");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] VersionFila {
            get {
                return this.VersionFilaField;
            }
            set {
                if ((object.ReferenceEquals(this.VersionFilaField, value) != true)) {
                    this.VersionFilaField = value;
                    this.RaisePropertyChanged("VersionFila");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityState", Namespace="http://schemas.datacontract.org/2004/07/Mre.Sicof.CuentasConsulares.Business.Enti" +
        "ty")]
    public enum EntityState : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unchanged = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Added = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Changed = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Deleted = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceComun.IServiceComun")]
    public interface IServiceComun {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceComun/TraerListaEntidadesAuspiciantesPorVisa", ReplyAction="http://tempuri.org/IServiceComun/TraerListaEntidadesAuspiciantesPorVisaResponse")]
        Mre.Externos.ServiceReferenceComun.EntidadAuspicianteCentroAdministrativo[] TraerListaEntidadesAuspiciantesPorVisa(int idActoConsularVisa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceComun/TraerListaEntidadesAuspiciantesPorVisa", ReplyAction="http://tempuri.org/IServiceComun/TraerListaEntidadesAuspiciantesPorVisaResponse")]
        System.Threading.Tasks.Task<Mre.Externos.ServiceReferenceComun.EntidadAuspicianteCentroAdministrativo[]> TraerListaEntidadesAuspiciantesPorVisaAsync(int idActoConsularVisa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceComun/ObtenerActividadesPorTipoVisa", ReplyAction="http://tempuri.org/IServiceComun/ObtenerActividadesPorTipoVisaResponse")]
        Mre.Externos.ServiceReferenceComun.ObtenerActividadesPorTipoVisa_Result[] ObtenerActividadesPorTipoVisa(int idActoConsularVisa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceComun/ObtenerActividadesPorTipoVisa", ReplyAction="http://tempuri.org/IServiceComun/ObtenerActividadesPorTipoVisaResponse")]
        System.Threading.Tasks.Task<Mre.Externos.ServiceReferenceComun.ObtenerActividadesPorTipoVisa_Result[]> ObtenerActividadesPorTipoVisaAsync(int idActoConsularVisa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceComun/TraerRequisitosVisasPorActoConsular", ReplyAction="http://tempuri.org/IServiceComun/TraerRequisitosVisasPorActoConsularResponse")]
        Mre.Externos.ServiceReferenceComun.Requisito[] TraerRequisitosVisasPorActoConsular(int idActoConsularVisa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceComun/TraerRequisitosVisasPorActoConsular", ReplyAction="http://tempuri.org/IServiceComun/TraerRequisitosVisasPorActoConsularResponse")]
        System.Threading.Tasks.Task<Mre.Externos.ServiceReferenceComun.Requisito[]> TraerRequisitosVisasPorActoConsularAsync(int idActoConsularVisa);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceComunChannel : Mre.Externos.ServiceReferenceComun.IServiceComun, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceComunClient : System.ServiceModel.ClientBase<Mre.Externos.ServiceReferenceComun.IServiceComun>, Mre.Externos.ServiceReferenceComun.IServiceComun {
        
        public ServiceComunClient() {
        }
        
        public ServiceComunClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceComunClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceComunClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceComunClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Mre.Externos.ServiceReferenceComun.EntidadAuspicianteCentroAdministrativo[] TraerListaEntidadesAuspiciantesPorVisa(int idActoConsularVisa) {
            return base.Channel.TraerListaEntidadesAuspiciantesPorVisa(idActoConsularVisa);
        }
        
        public System.Threading.Tasks.Task<Mre.Externos.ServiceReferenceComun.EntidadAuspicianteCentroAdministrativo[]> TraerListaEntidadesAuspiciantesPorVisaAsync(int idActoConsularVisa) {
            return base.Channel.TraerListaEntidadesAuspiciantesPorVisaAsync(idActoConsularVisa);
        }
        
        public Mre.Externos.ServiceReferenceComun.ObtenerActividadesPorTipoVisa_Result[] ObtenerActividadesPorTipoVisa(int idActoConsularVisa) {
            return base.Channel.ObtenerActividadesPorTipoVisa(idActoConsularVisa);
        }
        
        public System.Threading.Tasks.Task<Mre.Externos.ServiceReferenceComun.ObtenerActividadesPorTipoVisa_Result[]> ObtenerActividadesPorTipoVisaAsync(int idActoConsularVisa) {
            return base.Channel.ObtenerActividadesPorTipoVisaAsync(idActoConsularVisa);
        }
        
        public Mre.Externos.ServiceReferenceComun.Requisito[] TraerRequisitosVisasPorActoConsular(int idActoConsularVisa) {
            return base.Channel.TraerRequisitosVisasPorActoConsular(idActoConsularVisa);
        }
        
        public System.Threading.Tasks.Task<Mre.Externos.ServiceReferenceComun.Requisito[]> TraerRequisitosVisasPorActoConsularAsync(int idActoConsularVisa) {
            return base.Channel.TraerRequisitosVisasPorActoConsularAsync(idActoConsularVisa);
        }
    }
}
