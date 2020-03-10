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

    public interface IOpSvcFactory 
    {
        S Service<S>()   
            where S : unmanaged, IFunc
                => OpServices.Service<S>();
    }

    public interface IOpSvcFactory<S> :  IOpSvcFactory
        where S : unmanaged, IFunc
    {
        S Service  
        {
            [MethodImpl(Inline)]
            get => OpServices.Service<S>();
        }
    }

    public interface IOpSvcFactory<F,S> :  IOpSvcFactory<S>
        where F : unmanaged, IOpSvcFactory<S>
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
        public IEnumerable<MethodInfo> FactoryMethods 
            => typeof(F).DeclaredStaticMethods().Where(m => m.ReturnType.Realizes(typeof(IFunc)));
    }

    /// <summary>
    /// Identifies an operation service provider
    /// </summary>
    public class OpSvcFactoryProviderAttribute : Attribute, IOpSvcProvisioner
    {
        public OpSvcFactoryProviderAttribute()
        {
            this.ServiceCollectionName = string.Empty;
        }

        public OpSvcFactoryProviderAttribute(string name)
        {
            this.ServiceCollectionName =name;
        }

        public string ServiceCollectionName {get;}
    }

}