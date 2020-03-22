//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface IIdentityProvider
    {
        IdentityTargetKind ProviderKind {get;}   
    }
    
    public interface IIdentityProvider<S,T> : IIdentityProvider
        where T : IIdentified
    {

    }
}