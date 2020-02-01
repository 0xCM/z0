//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static zfunc;

    readonly struct TypeIdentityDefault : ITypeIdentityProvider
    {                    
        public Option<Moniker> DefineIdentity(Type arg)
            => arg.DefineDefaultIdentity();
    }
}