//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    readonly struct BitIdentityProvider : ITypeIdentityProvider
    {
        public TypeIdentity DefineIdentity(Type src)
            => src == typeof(bit) ? TypeIdentity.Define("1u") : TypeIdentity.Empty;
    }
}