//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    [ApiHost]
    public readonly partial struct BitfieldSpecs
    {
        const NumericKind Closure = UnsignedInts;
    }
}