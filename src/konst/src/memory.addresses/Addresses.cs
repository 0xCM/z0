//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    using DW = DataWidth;

    [ApiHost]
    public readonly partial struct Addresses
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static bool equals(RelativeAddress a, RelativeAddress b)
            => a.Offset == b.Offset && a.Grain == b.Grain;

    }
}