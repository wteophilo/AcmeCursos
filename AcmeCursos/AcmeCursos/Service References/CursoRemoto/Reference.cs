﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcmeCursos.CursoRemoto {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Curso", Namespace="http://schemas.datacontract.org/2004/07/AcmeService.Model", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Curso : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dataLimiteInscricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AcmeCursos.CursoRemoto.Inscricao[] inscricoesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AcmeCursos.CursoRemoto.ProfessorCurso[] lecionaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nomeField;
        
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
        public System.DateTime dataLimiteInscricao {
            get {
                return this.dataLimiteInscricaoField;
            }
            set {
                if ((this.dataLimiteInscricaoField.Equals(value) != true)) {
                    this.dataLimiteInscricaoField = value;
                    this.RaisePropertyChanged("dataLimiteInscricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descricao {
            get {
                return this.descricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.descricaoField, value) != true)) {
                    this.descricaoField = value;
                    this.RaisePropertyChanged("descricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AcmeCursos.CursoRemoto.Inscricao[] inscricoes {
            get {
                return this.inscricoesField;
            }
            set {
                if ((object.ReferenceEquals(this.inscricoesField, value) != true)) {
                    this.inscricoesField = value;
                    this.RaisePropertyChanged("inscricoes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AcmeCursos.CursoRemoto.ProfessorCurso[] leciona {
            get {
                return this.lecionaField;
            }
            set {
                if ((object.ReferenceEquals(this.lecionaField, value) != true)) {
                    this.lecionaField = value;
                    this.RaisePropertyChanged("leciona");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nome {
            get {
                return this.nomeField;
            }
            set {
                if ((object.ReferenceEquals(this.nomeField, value) != true)) {
                    this.nomeField = value;
                    this.RaisePropertyChanged("nome");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Inscricao", Namespace="http://schemas.datacontract.org/2004/07/AcmeService.Model", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Inscricao : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AcmeCursos.CursoRemoto.Curso cursoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int cursoIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dataInscricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AcmeCursos.CursoRemoto.Estudante estudanteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int estudanteIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
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
        public AcmeCursos.CursoRemoto.Curso curso {
            get {
                return this.cursoField;
            }
            set {
                if ((object.ReferenceEquals(this.cursoField, value) != true)) {
                    this.cursoField = value;
                    this.RaisePropertyChanged("curso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int cursoId {
            get {
                return this.cursoIdField;
            }
            set {
                if ((this.cursoIdField.Equals(value) != true)) {
                    this.cursoIdField = value;
                    this.RaisePropertyChanged("cursoId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime dataInscricao {
            get {
                return this.dataInscricaoField;
            }
            set {
                if ((this.dataInscricaoField.Equals(value) != true)) {
                    this.dataInscricaoField = value;
                    this.RaisePropertyChanged("dataInscricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AcmeCursos.CursoRemoto.Estudante estudante {
            get {
                return this.estudanteField;
            }
            set {
                if ((object.ReferenceEquals(this.estudanteField, value) != true)) {
                    this.estudanteField = value;
                    this.RaisePropertyChanged("estudante");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int estudanteId {
            get {
                return this.estudanteIdField;
            }
            set {
                if ((this.estudanteIdField.Equals(value) != true)) {
                    this.estudanteIdField = value;
                    this.RaisePropertyChanged("estudanteId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProfessorCurso", Namespace="http://schemas.datacontract.org/2004/07/AcmeService.Model", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class ProfessorCurso : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AcmeCursos.CursoRemoto.Curso cursoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int cursoIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AcmeCursos.CursoRemoto.Professor professorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int professorIdField;
        
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
        public AcmeCursos.CursoRemoto.Curso curso {
            get {
                return this.cursoField;
            }
            set {
                if ((object.ReferenceEquals(this.cursoField, value) != true)) {
                    this.cursoField = value;
                    this.RaisePropertyChanged("curso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int cursoId {
            get {
                return this.cursoIdField;
            }
            set {
                if ((this.cursoIdField.Equals(value) != true)) {
                    this.cursoIdField = value;
                    this.RaisePropertyChanged("cursoId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AcmeCursos.CursoRemoto.Professor professor {
            get {
                return this.professorField;
            }
            set {
                if ((object.ReferenceEquals(this.professorField, value) != true)) {
                    this.professorField = value;
                    this.RaisePropertyChanged("professor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int professorId {
            get {
                return this.professorIdField;
            }
            set {
                if ((this.professorIdField.Equals(value) != true)) {
                    this.professorIdField = value;
                    this.RaisePropertyChanged("professorId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Estudante", Namespace="http://schemas.datacontract.org/2004/07/AcmeService.Model", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Estudante : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dataMatriculaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AcmeCursos.CursoRemoto.Inscricao[] inscricoesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string sobrenomeField;
        
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
        public System.DateTime dataMatricula {
            get {
                return this.dataMatriculaField;
            }
            set {
                if ((this.dataMatriculaField.Equals(value) != true)) {
                    this.dataMatriculaField = value;
                    this.RaisePropertyChanged("dataMatricula");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AcmeCursos.CursoRemoto.Inscricao[] inscricoes {
            get {
                return this.inscricoesField;
            }
            set {
                if ((object.ReferenceEquals(this.inscricoesField, value) != true)) {
                    this.inscricoesField = value;
                    this.RaisePropertyChanged("inscricoes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nome {
            get {
                return this.nomeField;
            }
            set {
                if ((object.ReferenceEquals(this.nomeField, value) != true)) {
                    this.nomeField = value;
                    this.RaisePropertyChanged("nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string sobrenome {
            get {
                return this.sobrenomeField;
            }
            set {
                if ((object.ReferenceEquals(this.sobrenomeField, value) != true)) {
                    this.sobrenomeField = value;
                    this.RaisePropertyChanged("sobrenome");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Professor", Namespace="http://schemas.datacontract.org/2004/07/AcmeService.Model", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Professor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AcmeCursos.CursoRemoto.ProfessorCurso[] lecionaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string sobrenomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string titulacaoField;
        
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
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AcmeCursos.CursoRemoto.ProfessorCurso[] leciona {
            get {
                return this.lecionaField;
            }
            set {
                if ((object.ReferenceEquals(this.lecionaField, value) != true)) {
                    this.lecionaField = value;
                    this.RaisePropertyChanged("leciona");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nome {
            get {
                return this.nomeField;
            }
            set {
                if ((object.ReferenceEquals(this.nomeField, value) != true)) {
                    this.nomeField = value;
                    this.RaisePropertyChanged("nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string sobrenome {
            get {
                return this.sobrenomeField;
            }
            set {
                if ((object.ReferenceEquals(this.sobrenomeField, value) != true)) {
                    this.sobrenomeField = value;
                    this.RaisePropertyChanged("sobrenome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string titulacao {
            get {
                return this.titulacaoField;
            }
            set {
                if ((object.ReferenceEquals(this.titulacaoField, value) != true)) {
                    this.titulacaoField = value;
                    this.RaisePropertyChanged("titulacao");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CursoRemoto.ICursoService")]
    public interface ICursoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICursoService/adiciona", ReplyAction="http://tempuri.org/ICursoService/adicionaResponse")]
        void adiciona(AcmeCursos.CursoRemoto.Curso curso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICursoService/adiciona", ReplyAction="http://tempuri.org/ICursoService/adicionaResponse")]
        System.Threading.Tasks.Task adicionaAsync(AcmeCursos.CursoRemoto.Curso curso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICursoService/remove", ReplyAction="http://tempuri.org/ICursoService/removeResponse")]
        void remove(AcmeCursos.CursoRemoto.Curso curso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICursoService/remove", ReplyAction="http://tempuri.org/ICursoService/removeResponse")]
        System.Threading.Tasks.Task removeAsync(AcmeCursos.CursoRemoto.Curso curso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICursoService/atualiza", ReplyAction="http://tempuri.org/ICursoService/atualizaResponse")]
        void atualiza(AcmeCursos.CursoRemoto.Curso curso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICursoService/atualiza", ReplyAction="http://tempuri.org/ICursoService/atualizaResponse")]
        System.Threading.Tasks.Task atualizaAsync(AcmeCursos.CursoRemoto.Curso curso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICursoService/procura", ReplyAction="http://tempuri.org/ICursoService/procuraResponse")]
        AcmeCursos.CursoRemoto.Curso procura(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICursoService/procura", ReplyAction="http://tempuri.org/ICursoService/procuraResponse")]
        System.Threading.Tasks.Task<AcmeCursos.CursoRemoto.Curso> procuraAsync(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICursoService/lista", ReplyAction="http://tempuri.org/ICursoService/listaResponse")]
        AcmeCursos.CursoRemoto.Curso[] lista();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICursoService/lista", ReplyAction="http://tempuri.org/ICursoService/listaResponse")]
        System.Threading.Tasks.Task<AcmeCursos.CursoRemoto.Curso[]> listaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICursoService/detalhe", ReplyAction="http://tempuri.org/ICursoService/detalheResponse")]
        AcmeCursos.CursoRemoto.Curso detalhe(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICursoService/detalhe", ReplyAction="http://tempuri.org/ICursoService/detalheResponse")]
        System.Threading.Tasks.Task<AcmeCursos.CursoRemoto.Curso> detalheAsync(System.Nullable<int> id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICursoServiceChannel : AcmeCursos.CursoRemoto.ICursoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CursoServiceClient : System.ServiceModel.ClientBase<AcmeCursos.CursoRemoto.ICursoService>, AcmeCursos.CursoRemoto.ICursoService {
        
        public CursoServiceClient() {
        }
        
        public CursoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CursoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CursoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CursoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void adiciona(AcmeCursos.CursoRemoto.Curso curso) {
            base.Channel.adiciona(curso);
        }
        
        public System.Threading.Tasks.Task adicionaAsync(AcmeCursos.CursoRemoto.Curso curso) {
            return base.Channel.adicionaAsync(curso);
        }
        
        public void remove(AcmeCursos.CursoRemoto.Curso curso) {
            base.Channel.remove(curso);
        }
        
        public System.Threading.Tasks.Task removeAsync(AcmeCursos.CursoRemoto.Curso curso) {
            return base.Channel.removeAsync(curso);
        }
        
        public void atualiza(AcmeCursos.CursoRemoto.Curso curso) {
            base.Channel.atualiza(curso);
        }
        
        public System.Threading.Tasks.Task atualizaAsync(AcmeCursos.CursoRemoto.Curso curso) {
            return base.Channel.atualizaAsync(curso);
        }
        
        public AcmeCursos.CursoRemoto.Curso procura(System.Nullable<int> id) {
            return base.Channel.procura(id);
        }
        
        public System.Threading.Tasks.Task<AcmeCursos.CursoRemoto.Curso> procuraAsync(System.Nullable<int> id) {
            return base.Channel.procuraAsync(id);
        }
        
        public AcmeCursos.CursoRemoto.Curso[] lista() {
            return base.Channel.lista();
        }
        
        public System.Threading.Tasks.Task<AcmeCursos.CursoRemoto.Curso[]> listaAsync() {
            return base.Channel.listaAsync();
        }
        
        public AcmeCursos.CursoRemoto.Curso detalhe(System.Nullable<int> id) {
            return base.Channel.detalhe(id);
        }
        
        public System.Threading.Tasks.Task<AcmeCursos.CursoRemoto.Curso> detalheAsync(System.Nullable<int> id) {
            return base.Channel.detalheAsync(id);
        }
    }
}
