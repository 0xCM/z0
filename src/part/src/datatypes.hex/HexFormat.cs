//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static HexFormatSpecs;
    using static memory;

    public readonly partial struct HexFormat
    {
        const NumericKind Closure = UnsignedInts;

    }
}