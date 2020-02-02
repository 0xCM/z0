//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

    public interface ITypeIdentityProvider
    {
        Option<Moniker> DefineIdentity(Type src);        

        
    }
}