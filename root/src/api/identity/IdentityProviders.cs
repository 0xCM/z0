//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Root;

    public static class IdentityProviders
    {
        public static ITypeIdentityProvider find(Type src, Func<Type,ITypeIdentityProvider> fallback)
            => TypeIdentityProviders.GetOrAdd(src.EffectiveType(), fallback);

        public static IOpIdentityProvider find(Type src, Func<IOpIdentityProvider> fallback)
            => OpIdentityProviders.GetOrAdd(src.EffectiveType(),t => fallback());

        static ConcurrentDictionary<Type, IOpIdentityProvider> OpIdentityProviders 
            = new ConcurrentDictionary<Type, IOpIdentityProvider>();

        static ConcurrentDictionary<Type, ITypeIdentityProvider> TypeIdentityProviders 
            = new ConcurrentDictionary<Type, ITypeIdentityProvider>();
    }    

    public interface IIdentityProvider
    {
        IdentityTarget ProviderKind {get;}   
    }
    
    public interface IIdentityProvider<S,T> : IIdentityProvider
        where T : IIdentity
    {

    }

    public class IdentityProviderAttribute : Attribute
    {
        /// <summary>
        /// Use of this constructor implies that the attribution target is the provider
        /// </summary>
        public IdentityProviderAttribute()
        {
            Host = Option.none<Type>();
        }
        
        public IdentityProviderAttribute(Type host)
        {
            this.Host = host;
        }

        public Option<Type> Host;
    }    
        
}