//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Components;

    public static class _IdentityProviders
    {
        public static ITypeIdentityProvider find(Type src, Func<Type,ITypeIdentityProvider> fallback)
            => TypeIdentityProviders.GetOrAdd(src._EffectiveType(), fallback);

        static ConcurrentDictionary<Type, ITypeIdentityProvider> TypeIdentityProviders 
            = new ConcurrentDictionary<Type, ITypeIdentityProvider>();

        static Type _EffectiveType(this Type src)
            => src.UnderlyingSystemType.IsByRef ? src.GetElementType() : src;
    }
}