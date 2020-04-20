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