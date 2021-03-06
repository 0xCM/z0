//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct CpuBits
    {
        const NumericKind Closure = UnsignedInts;

        public static BlockedBits<T> blocked<T>(uint bitcount)
            where T : unmanaged
                => new BlockedBits<T>(SpanBlocks.alloc<T>(n64, CellCalcs.bitcover<T>(bitcount)), bitcount);

        public static Vector256<byte> widths<F>(W256 w)
            where F : unmanaged, Enum
        {
            Span<F> values = Enums.literals<F>();
            var widths = values.Bytes();
            var count = root.min(widths.Length, 32);
            var data = default(Vector256<byte>);
            for(var i=0; i<count; i++)
                data = data.WithElement(i, skip(widths,i));
            return data;
        }
   }
}