//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    [ApiHost]
    public readonly partial struct cpu
    {
        const NumericKind Closure = UnsignedInts;
    }

    [ApiHost]
    public readonly partial struct gcpu
    {
        const NumericKind Closure = UnsignedInts;
    }

    public static partial class XTend
    {
        const NumericKind Closure = UnsignedInts;

    }

    partial struct z
    {
        const NumericKind Closure = UnsignedInts;
    }
}