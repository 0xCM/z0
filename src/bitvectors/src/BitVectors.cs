//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost("api")]
    public partial class BitVector
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        internal static Span<byte> bytes<T>(in T src)
            where T : struct
                => z.bytes(src);
    }

    public static partial class XTend
    {

    }

    public static partial class XBv
    {

    }
}