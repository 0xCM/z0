//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;
    using static BlockStorage;
    partial class zfoc
    {
        public static ReadOnlySpan<char> hexdigits(ushort a)
            => Hex.digits(a);

        public static char hexdigit(byte a)
            => Hex.digit(a);

        public static void hexdigits(byte a, out char d0, out char d1)
            => Hex.digits(a, out d0, out d1);

        public static void datablock_store(in byte src, uint count, ref Block128 dst)
            => DataBlocks.store(in src, count, ref dst);

        public static void datablock_bytes(ref Block128 src)
            => DataBlocks.bytes(ref src);

        public static ReadOnlySpan<byte> bitseq(byte value)
            => BitStore.select(value);

        public static Span<byte> bitseq2(ulong value)
            => BitStore.bitseq2(value);

        public static ReadOnlySpan<byte> bitseq(int offset, int count)
            => BitStore.select(offset,count);


        public static ReadOnlySpan<byte> bitseq8u(byte src)
            => BitStore.bitseq(src);


    }

}