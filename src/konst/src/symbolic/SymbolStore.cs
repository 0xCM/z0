//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost(ApiNames.SymbolStore, true)]
    public readonly partial struct SymbolStore
    {
        const NumericKind Closure = UnsignedInts;
    }
}