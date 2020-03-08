//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface ITypeIdentityProvider : IIdentityProvider<Type,TypeIdentity>
    {
        TypeIdentity DefineIdentity(Type src);        

        IdentityKind IIdentityProvider.ProviderKind => IdentityKind.Type;
    }

    /// <summary>
    /// Characterizes a type identity provider than can define an identity predicated on a parametric type
    /// </summary>
    /// <typeparam name="T">The type for which identity will be defined</typeparam>
    public interface ITypeIdentityProvider<T> : ITypeIdentityProvider
    {
        TypeIdentity DefineIdentity();
        
        TypeIdentity ITypeIdentityProvider.DefineIdentity(Type src)
            => DefineIdentity();
    }
}