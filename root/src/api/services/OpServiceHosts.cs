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

    public readonly struct OpServiceHosts : IOpServiceHosts
    {
        Func<IEnumerable<Type>> Factory {get;}
        
        [MethodImpl(Inline)]
        public static IOpServiceHosts Create(Func<IEnumerable<Type>> hosts)
            => new OpServiceHosts(hosts);

        public Type[] HostTypes
            => Factory?.Invoke()?.ToArray() ?? array<Type>();

        [MethodImpl(Inline)]
        OpServiceHosts(Func<IEnumerable<Type>> f)
        {
            this.Factory = f;
        }
    }

    public abstract class OpServiceHosts<P>: IOpServiceHosts<P>
        where P : IOpServiceHosts<P>, new()
    {
        public Type[] HostTypes 
            => typeof(P).GetNestedTypes().Realize<IFunc>().ToArray();
    }        
}