//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

    public readonly struct TypeIdentity : ITypeIdentityProvider
    {     
        public static ITypeIdentityProvider Default
            => default(TypeIdentityDefault);

        /// <summary>
        /// Creates a type identity provider from a function
        /// </summary>
        /// <param name="f">The defining function</param>
        public static ITypeIdentityProvider From(Func<Type,Option<Moniker>> f)
            => new TypeIdentity(f);

        readonly Func<Type, Option<Moniker>> f;
        
        [MethodImpl(Inline)]
        internal TypeIdentity(Func<Type, Option<Moniker>> f)
            => this.f = f;
        
        [MethodImpl(Inline)]
        public Option<Moniker> DefineIdentity(Type src)
            => f(src);
    }
}