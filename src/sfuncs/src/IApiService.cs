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

    /// <summary>
    /// Characterizes a service that exposes serviced api operations
    /// </summary>
    public interface IApiService
    {        
        /// <summary>
        /// The known types that reify contracted operation services, potentially generic
        /// </summary>
        IEnumerable<Type> HostTypes {get;}

        /// <summary>
        /// The methods that instantiate services reified by the hosts
        /// </summary>
        IEnumerable<MethodInfo> FactoryMethods {get;}

        /// <summary>
        /// Specifies the number of service hosts described by the catalog
        /// </summary>
        int HostCount => HostTypes.Count();

        /// <summary>
        /// Specifies whether the catalog describes any service hosts
        /// </summary>
        bool IsNonEmpty => HostCount != 0;
    }

    public interface IApiService<S> : IApiService
        where S : IApiService<S>, new()
    {
        IEnumerable<Type> IApiService.HostTypes 
            => typeof(S).GetNestedTypes().Realize<ISFuncApi>();

        IEnumerable<MethodInfo> IApiService.FactoryMethods 
            => from m in typeof(S).DeclaredStaticMethods()
               where m.ReturnType.Realizes(typeof(ISFuncApi)) 
               select m;
    }

    public interface IApiService<S,H> : IApiService<S>
        where S : IApiService<S,H>, new()
    {
        IEnumerable<Type> IApiService.HostTypes 
            => typeof(H).GetNestedTypes().Realize<ISFuncApi>();

        IEnumerable<MethodInfo> IApiService.FactoryMethods 
            => from m in typeof(S).DeclaredStaticMethods()
               where m.ReturnType.Realizes(typeof(ISFuncApi)) 
               select m;
    }
}