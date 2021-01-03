//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost("formatting.factories")]
    public readonly partial struct Formatters
    {
        const NumericKind Closure = UnsignedInts;
    }
}