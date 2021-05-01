//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct Sources
    {
        const NumericKind Closure = AllNumeric;

        [MethodImpl(Inline), Op]
        public static Cell8 cell(ISource source, W8 w)
            => source.Next<byte>();

        [MethodImpl(Inline), Op]
        public static Cell16 cell(ISource source, W16 w)
            => source.Next<ushort>();

        [MethodImpl(Inline), Op]
        public static Cell32 cell(ISource source, W32 w)
            => source.Next<uint>();

        [MethodImpl(Inline), Op]
        public static Cell64 cell(ISource source, W64 w)
            => source.Next<ulong>();

        [MethodImpl(Inline), Op]
        public static Cell128 cell(ISource source, W128 w)
            => source.ConstPair<ulong>();

        [MethodImpl(Inline), Op]
        public static Cell256 cell(ISource source, W256 w)
        {
            var dst = Cell256.Empty;
            ref var storage = ref Unsafe.As<Cell256,Vector256<ulong>>(ref dst);
            storage = storage.WithLower(cell(source,w128));
            storage = storage.WithUpper(cell(source,w128));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Cell512 cell(ISource source, W512 w)
        {
            var lo = cell(source,w256);
            var hi = cell(source,w256);
            return new Cell512(lo,hi);
        }
    }

    [ApiHost]
    public static partial class XSource
    {
        const NumericKind Closure = AllNumeric;
    }
}
