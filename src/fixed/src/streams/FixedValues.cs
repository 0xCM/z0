//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Widths;
    using static Root;

    [ApiHost]
    public readonly struct FixedValues
    {
        [MethodImpl(Inline), Op]
        public static FixedCell8 next(IValueSource source, W8 w)
            => source.Next<byte>();

        [MethodImpl(Inline), Op]
        public static FixedCell16 next(IValueSource source, W16 w)
            => source.Next<ushort>();

        [MethodImpl(Inline), Op]
        public static Fixed32 next(IValueSource source, W32 w)
            => source.Next<uint>();

        [MethodImpl(Inline), Op]
        public static FixedCell64 next(IValueSource source, W64 w)
            => source.Next<ulong>();

        [MethodImpl(Inline), Op]
        public static FixedCell128 next(IValueSource source, W128 w)
            => source.NextPair<ulong>();

        [MethodImpl(Inline), Op]
        public static FixedCell256 next(IValueSource source, W256 w)
        {
            var dst = FixedCell256.Empty;
            ref var storage = ref Unsafe.As<FixedCell256,Vector256<ulong>>(ref dst);
            storage = storage.WithLower(next(source,w128));
            storage = storage.WithUpper(next(source,w128));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static FixedCell512 next(IValueSource source, W512 w)
        {
            var lo = next(source,w256);
            var hi = next(source,w256);
            return new FixedCell512(lo,hi);
        }
    }
}