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
}