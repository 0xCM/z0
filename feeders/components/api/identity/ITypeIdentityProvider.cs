//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Reflection;

    using static Components;

    public interface ITypeIdentityProvider : IIdentityProvider<Type,TypeIdentity>
    {
        TypeIdentity DefineIdentity(Type src);  

        IEnumerable<Type> Identifiable 
            => seq<Type>();

        IIdentified IIdentifier<Type>.Identify(Type src)
            => DefineIdentity(src);

        IdentityTargetKind IIdentityProvider.ProviderKind 
            => IdentityTargetKind.Type;
    }

    /// <summary>
    /// Characterizes a type identity provider than can define an identity predicated on a parametric type
    /// </summary>
    /// <typeparam name="T">The type for which identity will be defined</typeparam>
    public interface ITypeIdentityProvider<T> : ITypeIdentityProvider
    {
        TypeIdentity DefineIdentity();
        
        IEnumerable<Type> ITypeIdentityProvider.Identifiable
            => seq<Type>();

        TypeIdentity ITypeIdentityProvider.DefineIdentity(Type src)
            => DefineIdentity();
    }    

    public interface ITypeIdentityProviders : IService
    {
        ITypeIdentityProvider Find(Type src, Func<Type,ITypeIdentityProvider> fallback);
    }
}