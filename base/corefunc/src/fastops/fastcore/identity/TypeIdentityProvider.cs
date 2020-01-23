//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly struct TypeIdentityProvider : ITypeIdentityProvider
    {
        /// <summary>
        /// Creates a type identity provider from a function
        /// </summary>
        /// <param name="f">A function that produces a canonical identifier for a type</param>
        [MethodImpl(Inline)]
        public static ITypeIdentityProvider FromFunction(Func<Type,Moniker> f)
            => new TypeIdentityProvider(f);

        /// <summary>
        /// Creates a type identity provider from a host type that realizes the required interface, if possible;
        /// otherwise, returns none
        /// </summary>
        /// <param name="host">A type that realizes an identity provider</param>
        [MethodImpl(Inline)]
        public static Option<ITypeIdentityProvider> FromHost(Type host)
            => Try(() => Activator.CreateInstance(host) as ITypeIdentityProvider);
        
        readonly Func<Type,Moniker> f;
        
        [MethodImpl(Inline)]
        public TypeIdentityProvider(Func<Type,Moniker> f)
            => this.f = f;
        
        [MethodImpl(Inline)]
        public Moniker DefineIdentity(Type src)
            => f(src);
    }
}