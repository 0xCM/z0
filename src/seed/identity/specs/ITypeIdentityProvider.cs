//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;

    public interface ITypeIdentityProvider : IIdentityProvider<Type,TypeIdentity>
    {        
        IEnumerable<Type> Identifiable 
            => seq<Type>();

        bool CanIdentify(Type src)
            => Identifiable.Contains(src);

        IIdentified IIdentityProvider<Type>.Identify(Type src)
            => Identify(src);

        IdentityTargetKind IIdentityProvider.ProviderKind 
            => IdentityTargetKind.Type;
    }

    /// <summary>
    /// Characterizes a type identity provider than can define an identity predicated solely on a parametric type
    /// </summary>
    /// <typeparam name="S">The type for which identity will be defined</typeparam>
    public interface ITypeIdentityProvider<S> : ITypeIdentityProvider
    {
        TypeIdentity Identity();
        
        IEnumerable<Type> ITypeIdentityProvider.Identifiable
            => seq(typeof(S));

        TypeIdentity IIdentityProvider<Type,TypeIdentity>.Identify(Type src)
            => Identity();
    }    

    public interface ITypeIdentityProvider<F,T> : ITypeIdentityProvider
        where F : struct, ITypeIdentityProvider<F,T>
        where T : struct, IIdentifiedType
    {
        new T Identify(Type src);

        TypeIdentity IIdentityProvider<Type,TypeIdentity>.Identify(Type src)
            => TypeIdentity.Define(Identify(src).Identifier);
    }

    public interface ITypeIdentityProviders : IService
    {
        ITypeIdentityProvider Find(Type src, Func<Type,ITypeIdentityProvider> fallback);
    }
}