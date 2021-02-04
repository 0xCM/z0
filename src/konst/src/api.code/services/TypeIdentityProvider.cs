//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TypeIdentityProvider : ITypeIdentityProvider
    {
        readonly Func<Type,TypeIdentity> f;

        [MethodImpl(Inline)]
        public TypeIdentityProvider(Func<Type, TypeIdentity> f)
            => this.f = f;

        [MethodImpl(Inline)]
        public TypeIdentity Identify(Type src)
            => f(src);
    }
}