//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Concurrent;
    using System.Runtime.CompilerServices;

    using static Root;

    public class TypeIdentityProviders : ITypeIdentityProviders
    {
        public IContext Context {get;}
        
        readonly ITypeIdentityProvider DefaultProvider;

        public static ITypeIdentityProviders Create(IContext context, ITypeIdentityProvider @default, params ITypeIdentityProvider[] known)
            => new TypeIdentityProviders(context,  @default, known);

        TypeIdentityProviders(IContext context, ITypeIdentityProvider @default,  ITypeIdentityProvider[] known)
        {
            this.Context = context;            
            this.DefaultProvider = @default;
        }

        public ITypeIdentityProvider Find(Type src, Func<Type, ITypeIdentityProvider> fallback)
            => Cache.GetOrAdd(src.EffectiveType(), fallback);

        ConcurrentDictionary<Type, ITypeIdentityProvider> Cache 
            = new ConcurrentDictionary<Type, ITypeIdentityProvider>();
    }
}