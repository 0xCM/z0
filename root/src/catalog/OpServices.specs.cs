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

    /// <summary>
    /// Identifies an operation service provider
    /// </summary>
    public class OpServiceProviderAttribute : Attribute
    {

        public OpServiceProviderAttribute()
        {
            this.ProviderName = string.Empty;
        }

        public OpServiceProviderAttribute(string name)
        {
            this.ProviderName =name;
        }

        public string ProviderName {get;}
    }

    public interface IOpServiceProvider
    {
        
        /// <summary>
        /// The known types that reify contracted operation services, potentially generic
        /// </summary>
        IEnumerable<Type> ServiceHostTypes {get;}
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
}