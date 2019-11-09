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

    partial class zfoc
    {
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

        public static ByteInfo byteinfo(byte src)
            => BitStore.info(src);

        public static ReadOnlySpan<byte> bitseq8i(sbyte src)
            => BitStore.bitseq(src);

        public static ReadOnlySpan<byte> bitseq8u(byte src)
            => BitStore.bitseq(src);

        public static ReadOnlySpan<byte> bitseq16i(short src)
            => BitStore.bitseq(src);

        public static ReadOnlySpan<byte> bitseq16u(ushort src)
            => BitStore.bitseq(src);

        public static ReadOnlySpan<byte> bitseq32i(int src)
            => BitStore.bitseq(src);

        public static ReadOnlySpan<byte> bitseq32u(uint src)
            => BitStore.bitseq(src);

        public static ReadOnlySpan<byte> bitseq64i(long src)
            => BitStore.bitseq(src);

        public static ReadOnlySpan<byte> bitseq64u(ulong src)
            => BitStore.bitseq(src);

        public static ReadOnlySpan<byte> bitseq32f(float src)
            => BitStore.bitseq(src);

        public static ReadOnlySpan<byte> bitseq64f(double src)
            => BitStore.bitseq(src);


    }

}