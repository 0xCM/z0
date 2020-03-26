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

    using static Api;

    public interface IApiServiceFactory 
    {
        S Service<S>()   
            where S : unmanaged, ISFuncApi
                => ApiServices.Service<S>();
    }

    public interface IApiServiceFactory<S> :  IApiServiceFactory
        where S : unmanaged, ISFuncApi
    {
        S Service  
        {
            [MethodImpl(Inline)]
            get => ApiServices.Service<S>();
        }
    }

    public interface IApiServiceFactory<F,S> :  IApiServiceFactory<S>
        where F : unmanaged, IApiServiceFactory<S>
        where S : unmanaged, ISFuncApi
        
    {

    }

    public interface IApiServiceFactoryProvider
    {
        IEnumerable<MethodInfo> FactoryMethods {get;}
    }

    public abstract class ApiSvcFactoryProvider<F> : IApiServiceFactoryProvider
        where F : ApiSvcFactoryProvider<F>, new()
    {
        public IEnumerable<MethodInfo> FactoryMethods 
            => typeof(F).DeclaredStaticMethods().Where(m => m.ReturnType.Realizes(typeof(ISFuncApi)));
    }
}