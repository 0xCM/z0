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

    public readonly struct OpServiceProvider : IOpServiceProvider
    {
        Func<IEnumerable<Type>> Factory {get;}
        
        [MethodImpl(Inline)]
        public static IOpServiceProvider Create(Func<IEnumerable<Type>> hosts)
            => new OpServiceProvider(hosts);

        public IEnumerable<Type> ServiceHostTypes
            => Factory?.Invoke()?.ToArray() ?? array<Type>();

        [MethodImpl(Inline)]
        OpServiceProvider(Func<IEnumerable<Type>> f)
        {
            this.Factory = f;
        }
    }
}