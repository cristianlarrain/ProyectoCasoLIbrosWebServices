﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Presentacion.CasoLibros.ServiceWeb_CasoLibros {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceWeb_CasoLibros.ConsutaLibrosSoap")]
    public interface ConsutaLibrosSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConsultarLibro", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string ConsultarLibro(int Codigo_Libro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConsultarLibro", ReplyAction="*")]
        System.Threading.Tasks.Task<string> ConsultarLibroAsync(int Codigo_Libro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConsultarStock", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string ConsultarStock(int Codigo_Libro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConsultarStock", ReplyAction="*")]
        System.Threading.Tasks.Task<string> ConsultarStockAsync(int Codigo_Libro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarProductos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ListarProductos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarProductos", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarProductosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConsultarLibroDB", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ConsultarLibroDB(int Codigo_Libro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConsultarLibroDB", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ConsultarLibroDBAsync(int Codigo_Libro);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ConsutaLibrosSoapChannel : Presentacion.CasoLibros.ServiceWeb_CasoLibros.ConsutaLibrosSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConsutaLibrosSoapClient : System.ServiceModel.ClientBase<Presentacion.CasoLibros.ServiceWeb_CasoLibros.ConsutaLibrosSoap>, Presentacion.CasoLibros.ServiceWeb_CasoLibros.ConsutaLibrosSoap {
        
        public ConsutaLibrosSoapClient() {
        }
        
        public ConsutaLibrosSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConsutaLibrosSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConsutaLibrosSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConsutaLibrosSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ConsultarLibro(int Codigo_Libro) {
            return base.Channel.ConsultarLibro(Codigo_Libro);
        }
        
        public System.Threading.Tasks.Task<string> ConsultarLibroAsync(int Codigo_Libro) {
            return base.Channel.ConsultarLibroAsync(Codigo_Libro);
        }
        
        public string ConsultarStock(int Codigo_Libro) {
            return base.Channel.ConsultarStock(Codigo_Libro);
        }
        
        public System.Threading.Tasks.Task<string> ConsultarStockAsync(int Codigo_Libro) {
            return base.Channel.ConsultarStockAsync(Codigo_Libro);
        }
        
        public System.Data.DataSet ListarProductos() {
            return base.Channel.ListarProductos();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarProductosAsync() {
            return base.Channel.ListarProductosAsync();
        }
        
        public System.Data.DataSet ConsultarLibroDB(int Codigo_Libro) {
            return base.Channel.ConsultarLibroDB(Codigo_Libro);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ConsultarLibroDBAsync(int Codigo_Libro) {
            return base.Channel.ConsultarLibroDBAsync(Codigo_Libro);
        }
    }
}
