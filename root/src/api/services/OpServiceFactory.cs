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

    public interface IOpServiceFactoryProvider
    {
        IEnumerable<MethodInfo> FactoryMethods {get;}
    }

    public abstract class OpSvcFactoryProvider<F> : IOpServiceFactoryProvider
        where F : OpSvcFactoryProvider<F>, new()
    {
        public IEnumerable<MethodInfo> FactoryMethods 
            => typeof(F).DeclaredStaticMethods().Where(m => m.ReturnType.Realizes(typeof(IFunc)));
    }

    /// <summary>
    /// Identifies an operation service provider
    /// </summary>
    public class OpSeviceFactoryProviderAttribute : Attribute, IOpServiceProvisioner
    {
        public OpSeviceFactoryProviderAttribute()
        {
            this.ServiceCollectionName = string.Empty;
        }

        public OpSeviceFactoryProviderAttribute(string name)
        {
            this.ServiceCollectionName =name;
        }

        public string ServiceCollectionName {get;}
    }

}