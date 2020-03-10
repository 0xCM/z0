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

    public readonly struct OpSvcHostProvider : IOpSvcHostProvider
    {
        Func<IEnumerable<Type>> Factory {get;}
        
        [MethodImpl(Inline)]
        public static IOpSvcHostProvider Create(Func<IEnumerable<Type>> hosts)
            => new OpSvcHostProvider(hosts);

        public Type[] ServiceHostTypes
            => Factory?.Invoke()?.ToArray() ?? array<Type>();

        [MethodImpl(Inline)]
        OpSvcHostProvider(Func<IEnumerable<Type>> f)
        {
            this.Factory = f;
        }
    }

    public abstract class OpSvcHostProvider<P>: IOpSvcHostProvider<P>
        where P : IOpSvcHostProvider<P>, new()
    {
        public Type[] ServiceHostTypes 
            => typeof(P).GetNestedTypes().Realize<IFunc>().ToArray();
    }        
}