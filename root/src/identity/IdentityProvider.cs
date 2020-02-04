//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;    
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Runtime.CompilerServices;

    using static RootShare;

    public interface ITypeIdentityProvider
    {
        TypeIdentity DefineIdentity(Type src);        
    }
    
    public interface IOpIdentityProvider
    {
        OpIdentity DefineIdentity(MethodInfo method);

        OpIdentity GroupIdentity(MethodInfo method);                    

        OpIdentity GenericIdentity(MethodInfo method);                    

        OpIdentity DefineIdentity(MethodInfo method, NumericKind k);
    }

    public class IdentityProviderAttribute : Attribute
    {
        public IdentityProviderAttribute(Type host)
        {
            this.Host = host;
        }

        public Type Host;
    }

    public static class IdentityProviders
    {
        public static ITypeIdentityProvider find(Type src, Func<Type,ITypeIdentityProvider> fallback)
            => TypeIdentityProviders.GetOrAdd(src.EffectiveType(),fallback);

        public static IOpIdentityProvider find(Type src, Func<IOpIdentityProvider> fallback)
            => OpIdentityProviders.GetOrAdd(src.EffectiveType(),t => fallback());

        static ConcurrentDictionary<Type, IOpIdentityProvider> OpIdentityProviders 
            = new ConcurrentDictionary<Type, IOpIdentityProvider>();

        static ConcurrentDictionary<Type, ITypeIdentityProvider> TypeIdentityProviders 
            = new ConcurrentDictionary<Type, ITypeIdentityProvider>();
    }
}