//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    public class TypeIdentityProviders : ITypeIdentityProviders
    {
        public IAppContext Context {get;}
        
        readonly ITypeIdentityProvider DefaultProvider;

        public static ITypeIdentityProviders Create(IAppContext context, ITypeIdentityProvider @default, params ITypeIdentityProvider[] known)
            => new TypeIdentityProviders(context,  @default, known);

        TypeIdentityProviders(IAppContext context, ITypeIdentityProvider @default,  ITypeIdentityProvider[] known)
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