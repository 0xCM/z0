//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zfunc;

    public readonly struct TypeIdentityProvider : ITypeIdentityProvider
    {     
        public static ITypeIdentityProvider Default
            => default(DefaultTypeIdentityProvider);

        readonly Func<Type, Moniker> f;
        
        [MethodImpl(Inline)]
        internal TypeIdentityProvider(Func<Type, Moniker> f)
            => this.f = f;
        
        [MethodImpl(Inline)]
        public Moniker DefineIdentity(Type src)
            => f(src);
    }


}