//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static RootShare;

    public interface IIdentityProvider
    {
        IdentityKind ProviderKind {get;}   
    }
    
    public interface IIdentityProvider<S,T> : IIdentityProvider
        where T : IIdentity
    {

    }
}