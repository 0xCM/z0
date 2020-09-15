//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    public interface IIdentityProvider
    {
        IdentityTargetKind ProviderKind {get;}

        IIdentified Identify(object src);
    }

    /// <summary>
    /// Characterizes a services capable of assigning identity to T-values
    /// </summary>
    /// <typeparam name="S">The subject of identification</typeparam>
    public interface IIdentityProvider<S> : IIdentityProvider
    {
        IIdentified Identify(S src);

        IIdentified IIdentityProvider.Identify(object src)
            => Identify((S)src);
    }

    public interface IIdentityProvider<S,T> : IIdentityProvider<S>
        where T : IIdentified
    {
        new T Identify(S src);

        IIdentified IIdentityProvider<S>.Identify(S src)
            => Identify(src);
    }

    public interface ITypeIdentityProvider : IIdentityProvider<Type,TypeIdentity>
    {
        IEnumerable<Type> Identifiable
            => z.stream<Type>();

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
            => z.stream(typeof(S));

        TypeIdentity IIdentityProvider<Type,TypeIdentity>.Identify(Type src)
            => Identity();
    }

    public interface ITypeIdentityProvider<F,T> : ITypeIdentityProvider
        where F : struct, ITypeIdentityProvider<F,T>
        where T : struct, IIdentifiedType
    {
        new T Identify(Type src);

        TypeIdentity IIdentityProvider<Type,TypeIdentity>.Identify(Type src)
            => TypeIdentity.define(Identify(src).Identifier);
    }
}