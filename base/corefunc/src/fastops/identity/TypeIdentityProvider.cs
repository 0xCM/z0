//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    using static zfunc;

    public static class TypeIdentityProvider
    {
        /// <summary>
        /// Attempts to create a type identity prodiver as directed by an attributed type
        /// or by a type that realizes the required interface
        /// </summary>
        /// <param name="t">The source type</param>
        public static ITypeIdentityProvider from(Type src)
        {
            var t = src.EffectiveType();
            return t.FromCache().ValueOrElse(() => t.CreateProvider());            
        }

        static ITypeIdentityProvider CreateProvider(this Type t)
        {
            var provider = default(ITypeIdentityProvider);   

            if(t.IsAttributed<IdentityProviderAttribute>())
                provider = t.FromAttributed().ValueOrElse(DefaultProvider);
            else if(t.Realizes<ITypeIdentityProvider>())
                provider = t.FromHost().ValueOrElse(DefaultProvider);
            else
                provider = DefaultProvider;
            return t.Cache(provider);
        }

        /// <summary>
        /// Creates a type identity provider from a host type that realizes the required interface, if possible;
        /// otherwise, returns none
        /// </summary>
        /// <param name="host">A type that realizes an identity provider</param>
        [MethodImpl(Inline)]
        static Option<ITypeIdentityProvider> FromHost(this Type host)
            => Try(() => Activator.CreateInstance(host) as ITypeIdentityProvider);

        [MethodImpl(Inline)]
        static Option<ITypeIdentityProvider> FromAttributed(this Type t)
            => from a in t.CustomAttribute<IdentityProviderAttribute>()
               from tid in FromHost(a.Host)
               select tid;

        [MethodImpl(Inline)]
        static Option<ITypeIdentityProvider> FromCache(this Type t)
            => CachedProviders.TryFind(t);
        
        [MethodImpl(Inline)]
        static ITypeIdentityProvider Cache(this Type t, ITypeIdentityProvider provider)
        {
            CachedProviders.TryAdd(t,provider);
            return provider;
        }

        static readonly ITypeIdentityProvider DefaultProvider
            = new FunctionalProvider(TypeIdentities.DefineDefaultIdentity);

        static ConcurrentDictionary<Type, ITypeIdentityProvider> CachedProviders 
            = new ConcurrentDictionary<Type, ITypeIdentityProvider>();

        readonly struct FunctionalProvider : ITypeIdentityProvider
        {     
            readonly Func<Type, TypeIdentity> f;
            
            [MethodImpl(Inline)]
            public FunctionalProvider(Func<Type, TypeIdentity> f)
                => this.f = f;
            
            [MethodImpl(Inline)]
            public TypeIdentity DefineIdentity(Type src)
                => f(src);
        }
    }
}