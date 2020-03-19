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

    public readonly struct ApiServiceHosts : IApiServiceHosts
    {
        Func<IEnumerable<Type>> Factory {get;}
        
        [MethodImpl(Inline)]
        public static IApiServiceHosts Create(Func<IEnumerable<Type>> hosts)
            => new ApiServiceHosts(hosts);

        public Type[] HostTypes
            => Factory?.Invoke()?.ToArray() ?? array<Type>();

        [MethodImpl(Inline)]
        ApiServiceHosts(Func<IEnumerable<Type>> f)
        {
            this.Factory = f;
        }
    }

    public abstract class ApiServiceHosts<P>: IApiServiceHosts<P>
        where P : IApiServiceHosts<P>, new()
    {
        public Type[] HostTypes 
            => typeof(P).GetNestedTypes().Realize<IFunc>().ToArray();
    }        
}