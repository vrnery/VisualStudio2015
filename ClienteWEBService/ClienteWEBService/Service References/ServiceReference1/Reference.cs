﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteWEBService.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="clPessoa", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class clPessoa : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cpfField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nomeField;
        
        private System.DateTime dt_nascimentoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string cpf {
            get {
                return this.cpfField;
            }
            set {
                if ((object.ReferenceEquals(this.cpfField, value) != true)) {
                    this.cpfField = value;
                    this.RaisePropertyChanged("cpf");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.DateTime dt_nascimento {
            get {
                return this.dt_nascimentoField;
            }
            set {
                if ((this.dt_nascimentoField.Equals(value) != true)) {
                    this.dt_nascimentoField = value;
                    this.RaisePropertyChanged("dt_nascimento");
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
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfClPessoa", Namespace="http://tempuri.org/", ItemName="clPessoa")]
    [System.SerializableAttribute()]
    public class ArrayOfClPessoa : System.Collections.Generic.List<ClienteWEBService.ServiceReference1.clPessoa> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ServicoPessoaSoap")]
    public interface ServicoPessoaSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ClienteWEBService.ServiceReference1.HelloWorldResponse HelloWorld(ClienteWEBService.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteWEBService.ServiceReference1.HelloWorldResponse> HelloWorldAsync(ClienteWEBService.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Soma", ReplyAction="*")]
        double Soma(double v1, double v2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Soma", ReplyAction="*")]
        System.Threading.Tasks.Task<double> SomaAsync(double v1, double v2);
        
        // CODEGEN: Generating message contract since element name cpf from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Salvar", ReplyAction="*")]
        ClienteWEBService.ServiceReference1.SalvarResponse Salvar(ClienteWEBService.ServiceReference1.SalvarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Salvar", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteWEBService.ServiceReference1.SalvarResponse> SalvarAsync(ClienteWEBService.ServiceReference1.SalvarRequest request);
        
        // CODEGEN: Generating message contract since element name CPF from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        ClienteWEBService.ServiceReference1.BuscarResponse Buscar(ClienteWEBService.ServiceReference1.BuscarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteWEBService.ServiceReference1.BuscarResponse> BuscarAsync(ClienteWEBService.ServiceReference1.BuscarRequest request);
        
        // CODEGEN: Generating message contract since element name BuscarTResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarT", ReplyAction="*")]
        ClienteWEBService.ServiceReference1.BuscarTResponse BuscarT(ClienteWEBService.ServiceReference1.BuscarTRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarT", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteWEBService.ServiceReference1.BuscarTResponse> BuscarTAsync(ClienteWEBService.ServiceReference1.BuscarTRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ClienteWEBService.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ClienteWEBService.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClienteWEBService.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ClienteWEBService.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SalvarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Salvar", Namespace="http://tempuri.org/", Order=0)]
        public ClienteWEBService.ServiceReference1.SalvarRequestBody Body;
        
        public SalvarRequest() {
        }
        
        public SalvarRequest(ClienteWEBService.ServiceReference1.SalvarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SalvarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string cpf;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string nome;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public System.DateTime dt_nascimento;
        
        public SalvarRequestBody() {
        }
        
        public SalvarRequestBody(string cpf, string nome, System.DateTime dt_nascimento) {
            this.cpf = cpf;
            this.nome = nome;
            this.dt_nascimento = dt_nascimento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SalvarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SalvarResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClienteWEBService.ServiceReference1.SalvarResponseBody Body;
        
        public SalvarResponse() {
        }
        
        public SalvarResponse(ClienteWEBService.ServiceReference1.SalvarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SalvarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SalvarResult;
        
        public SalvarResponseBody() {
        }
        
        public SalvarResponseBody(string SalvarResult) {
            this.SalvarResult = SalvarResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Buscar", Namespace="http://tempuri.org/", Order=0)]
        public ClienteWEBService.ServiceReference1.BuscarRequestBody Body;
        
        public BuscarRequest() {
        }
        
        public BuscarRequest(ClienteWEBService.ServiceReference1.BuscarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuscarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CPF;
        
        public BuscarRequestBody() {
        }
        
        public BuscarRequestBody(string CPF) {
            this.CPF = CPF;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClienteWEBService.ServiceReference1.BuscarResponseBody Body;
        
        public BuscarResponse() {
        }
        
        public BuscarResponse(ClienteWEBService.ServiceReference1.BuscarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuscarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ClienteWEBService.ServiceReference1.clPessoa BuscarResult;
        
        public BuscarResponseBody() {
        }
        
        public BuscarResponseBody(ClienteWEBService.ServiceReference1.clPessoa BuscarResult) {
            this.BuscarResult = BuscarResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarTRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarT", Namespace="http://tempuri.org/", Order=0)]
        public ClienteWEBService.ServiceReference1.BuscarTRequestBody Body;
        
        public BuscarTRequest() {
        }
        
        public BuscarTRequest(ClienteWEBService.ServiceReference1.BuscarTRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuscarTRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Idade;
        
        public BuscarTRequestBody() {
        }
        
        public BuscarTRequestBody(int Idade) {
            this.Idade = Idade;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarTResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarTResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClienteWEBService.ServiceReference1.BuscarTResponseBody Body;
        
        public BuscarTResponse() {
        }
        
        public BuscarTResponse(ClienteWEBService.ServiceReference1.BuscarTResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuscarTResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ClienteWEBService.ServiceReference1.ArrayOfClPessoa BuscarTResult;
        
        public BuscarTResponseBody() {
        }
        
        public BuscarTResponseBody(ClienteWEBService.ServiceReference1.ArrayOfClPessoa BuscarTResult) {
            this.BuscarTResult = BuscarTResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicoPessoaSoapChannel : ClienteWEBService.ServiceReference1.ServicoPessoaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoPessoaSoapClient : System.ServiceModel.ClientBase<ClienteWEBService.ServiceReference1.ServicoPessoaSoap>, ClienteWEBService.ServiceReference1.ServicoPessoaSoap {
        
        public ServicoPessoaSoapClient() {
        }
        
        public ServicoPessoaSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicoPessoaSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoPessoaSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoPessoaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteWEBService.ServiceReference1.HelloWorldResponse ClienteWEBService.ServiceReference1.ServicoPessoaSoap.HelloWorld(ClienteWEBService.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ClienteWEBService.ServiceReference1.HelloWorldRequest inValue = new ClienteWEBService.ServiceReference1.HelloWorldRequest();
            inValue.Body = new ClienteWEBService.ServiceReference1.HelloWorldRequestBody();
            ClienteWEBService.ServiceReference1.HelloWorldResponse retVal = ((ClienteWEBService.ServiceReference1.ServicoPessoaSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteWEBService.ServiceReference1.HelloWorldResponse> ClienteWEBService.ServiceReference1.ServicoPessoaSoap.HelloWorldAsync(ClienteWEBService.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteWEBService.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            ClienteWEBService.ServiceReference1.HelloWorldRequest inValue = new ClienteWEBService.ServiceReference1.HelloWorldRequest();
            inValue.Body = new ClienteWEBService.ServiceReference1.HelloWorldRequestBody();
            return ((ClienteWEBService.ServiceReference1.ServicoPessoaSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public double Soma(double v1, double v2) {
            return base.Channel.Soma(v1, v2);
        }
        
        public System.Threading.Tasks.Task<double> SomaAsync(double v1, double v2) {
            return base.Channel.SomaAsync(v1, v2);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteWEBService.ServiceReference1.SalvarResponse ClienteWEBService.ServiceReference1.ServicoPessoaSoap.Salvar(ClienteWEBService.ServiceReference1.SalvarRequest request) {
            return base.Channel.Salvar(request);
        }
        
        public string Salvar(string cpf, string nome, System.DateTime dt_nascimento) {
            ClienteWEBService.ServiceReference1.SalvarRequest inValue = new ClienteWEBService.ServiceReference1.SalvarRequest();
            inValue.Body = new ClienteWEBService.ServiceReference1.SalvarRequestBody();
            inValue.Body.cpf = cpf;
            inValue.Body.nome = nome;
            inValue.Body.dt_nascimento = dt_nascimento;
            ClienteWEBService.ServiceReference1.SalvarResponse retVal = ((ClienteWEBService.ServiceReference1.ServicoPessoaSoap)(this)).Salvar(inValue);
            return retVal.Body.SalvarResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteWEBService.ServiceReference1.SalvarResponse> ClienteWEBService.ServiceReference1.ServicoPessoaSoap.SalvarAsync(ClienteWEBService.ServiceReference1.SalvarRequest request) {
            return base.Channel.SalvarAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteWEBService.ServiceReference1.SalvarResponse> SalvarAsync(string cpf, string nome, System.DateTime dt_nascimento) {
            ClienteWEBService.ServiceReference1.SalvarRequest inValue = new ClienteWEBService.ServiceReference1.SalvarRequest();
            inValue.Body = new ClienteWEBService.ServiceReference1.SalvarRequestBody();
            inValue.Body.cpf = cpf;
            inValue.Body.nome = nome;
            inValue.Body.dt_nascimento = dt_nascimento;
            return ((ClienteWEBService.ServiceReference1.ServicoPessoaSoap)(this)).SalvarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteWEBService.ServiceReference1.BuscarResponse ClienteWEBService.ServiceReference1.ServicoPessoaSoap.Buscar(ClienteWEBService.ServiceReference1.BuscarRequest request) {
            return base.Channel.Buscar(request);
        }
        
        public ClienteWEBService.ServiceReference1.clPessoa Buscar(string CPF) {
            ClienteWEBService.ServiceReference1.BuscarRequest inValue = new ClienteWEBService.ServiceReference1.BuscarRequest();
            inValue.Body = new ClienteWEBService.ServiceReference1.BuscarRequestBody();
            inValue.Body.CPF = CPF;
            ClienteWEBService.ServiceReference1.BuscarResponse retVal = ((ClienteWEBService.ServiceReference1.ServicoPessoaSoap)(this)).Buscar(inValue);
            return retVal.Body.BuscarResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteWEBService.ServiceReference1.BuscarResponse> ClienteWEBService.ServiceReference1.ServicoPessoaSoap.BuscarAsync(ClienteWEBService.ServiceReference1.BuscarRequest request) {
            return base.Channel.BuscarAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteWEBService.ServiceReference1.BuscarResponse> BuscarAsync(string CPF) {
            ClienteWEBService.ServiceReference1.BuscarRequest inValue = new ClienteWEBService.ServiceReference1.BuscarRequest();
            inValue.Body = new ClienteWEBService.ServiceReference1.BuscarRequestBody();
            inValue.Body.CPF = CPF;
            return ((ClienteWEBService.ServiceReference1.ServicoPessoaSoap)(this)).BuscarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteWEBService.ServiceReference1.BuscarTResponse ClienteWEBService.ServiceReference1.ServicoPessoaSoap.BuscarT(ClienteWEBService.ServiceReference1.BuscarTRequest request) {
            return base.Channel.BuscarT(request);
        }
        
        public ClienteWEBService.ServiceReference1.ArrayOfClPessoa BuscarT(int Idade) {
            ClienteWEBService.ServiceReference1.BuscarTRequest inValue = new ClienteWEBService.ServiceReference1.BuscarTRequest();
            inValue.Body = new ClienteWEBService.ServiceReference1.BuscarTRequestBody();
            inValue.Body.Idade = Idade;
            ClienteWEBService.ServiceReference1.BuscarTResponse retVal = ((ClienteWEBService.ServiceReference1.ServicoPessoaSoap)(this)).BuscarT(inValue);
            return retVal.Body.BuscarTResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteWEBService.ServiceReference1.BuscarTResponse> ClienteWEBService.ServiceReference1.ServicoPessoaSoap.BuscarTAsync(ClienteWEBService.ServiceReference1.BuscarTRequest request) {
            return base.Channel.BuscarTAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteWEBService.ServiceReference1.BuscarTResponse> BuscarTAsync(int Idade) {
            ClienteWEBService.ServiceReference1.BuscarTRequest inValue = new ClienteWEBService.ServiceReference1.BuscarTRequest();
            inValue.Body = new ClienteWEBService.ServiceReference1.BuscarTRequestBody();
            inValue.Body.Idade = Idade;
            return ((ClienteWEBService.ServiceReference1.ServicoPessoaSoap)(this)).BuscarTAsync(inValue);
        }
    }
}
