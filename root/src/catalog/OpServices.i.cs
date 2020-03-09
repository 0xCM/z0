//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static Root;

    public interface IOpServiceProvisioner
    {
        string ServiceCollectionName {get;}
    }

    /// <summary>
    /// Identifies an operation service provider
    /// </summary>
    public class OpServiceProviderAttribute : Attribute, IOpServiceProvisioner
    {

        public OpServiceProviderAttribute()
        {
            this.ServiceCollectionName = string.Empty;
        }

        public OpServiceProviderAttribute(string name)
        {
            this.ServiceCollectionName = name;
        }

        public string ServiceCollectionName {get;}
    }

    /// <summary>
    /// Identifies an operation service provider
    /// </summary>
    public class OpServiceFactoryProviderAttribute : Attribute, IOpServiceProvisioner
    {

        public OpServiceFactoryProviderAttribute()
        {
            this.ServiceCollectionName = string.Empty;
        }

        public OpServiceFactoryProviderAttribute(string name)
        {
            this.ServiceCollectionName =name;
        }

        public string ServiceCollectionName {get;}
    }

    public interface IOpServiceProvider
    {        
        /// <summary>
        /// The known types that reify contracted operation services, potentially generic
        /// </summary>
        IEnumerable<Type> ServiceHostTypes {get;}
    }

    public interface IOpServiceProvider<P> : IOpServiceProvider
        where P : IOpServiceProvider<P>, new()
    {

    }

    public abstract class OpServiceProvider<P>: IOpServiceProvider<P>
        where P : IOpServiceProvider<P>, new()
    {
        public IEnumerable<Type> ServiceHostTypes 
            => typeof(P).GetNestedTypes().Realize<IFunc>();
    }

    
    public interface IOpServiceFactory 
    {
        S Service<S>()   
            where S : unmanaged, IFunc
                => OpServices.Service<S>();
    }

    public interface IOpServiceFactory<S> :  IOpServiceFactory
        where S : unmanaged, IFunc
    {
        S Service  
        {
            [MethodImpl(Inline)]
            get => OpServices.Service<S>();
        }
    }

    public interface IOpServiceFactory<F,S> :  IOpServiceFactory<S>
        where F : unmanaged, IOpServiceFactory<S>
        where S : unmanaged, IFunc
        
    {

    }

    public interface IOpSvcFactoryProvider
    {
        IEnumerable<MethodInfo> FactoryMethods {get;}
    }

    public abstract class OpSvcFactoryProvider<F> : IOpSvcFactoryProvider
        where F : OpSvcFactoryProvider<F>, new()
    {
        public virtual IEnumerable<MethodInfo> FactoryMethods 
            => typeof(F).DeclaredStaticMethods().Where(m => m.ReturnType.Realizes(typeof(IFunc)));

    }
}