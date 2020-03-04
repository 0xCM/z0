//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static Stacked;
    using static P2K;

    [OpCodeProvider]
    public static class stacked
    {
        public static MemStack64 ss_alloc_64()
            => Stacks.alloc(p2x6);

        public static MemStack128 ss_alloc_128()
            => Stacks.alloc(p2x7);

        public static MemStack256 ss_alloc_256()
            => Stacks.alloc(p2x8);

        public static MemStack512 ss_alloc_512()
            => Stacks.alloc(p2x9);

        public static MemStack1024 ss_alloc_1024()
            => Stacks.alloc(p2x10);

        public static void ss_store_128(in byte src, uint count, ref MemStack128 dst)
            => Stacks.store(in src, count, ref dst);

        public static Span<byte> ss_span_128x8(ref MemStack128 src)
            => Stacks.span(ref src,z8);

        public static Span<byte> ss_span_256x8(ref MemStack256 src)
            => Stacks.span(ref src,z8);

        public static ref byte ss_head_128x8(ref MemStack128 src)
            => ref Stacks.head(ref src,z8);

        public static ref ushort ss_head_128x16(ref MemStack128 src)
            => ref Stacks.head(ref src,z16);

        public static ref uint ss_head_128x32(ref MemStack128 src)
            => ref Stacks.head(ref src,z32);

        public static ref ulong ss_head_128x64(ref MemStack128 src)
            => ref Stacks.head(ref src,z64);

        public static ref byte ss_value_128x8(ref MemStack128 src, int index)
            => ref Stacks.cell(ref src, index, z8);

        public static ref ushort ss_value_128x16(ref MemStack128 src, int index)
            => ref Stacks.cell(ref src, index, z16);

        public static ref uint ss_value_128x32(ref MemStack128 src, int index)
            => ref Stacks.cell(ref src, index, z32);

        public static ref ulong ss_value_128x64(ref MemStack128 src, int index)
            => ref Stacks.cell(ref src, index, z64);

        public static ref byte ss_value_256x8(ref MemStack256 src, int index)
            => ref Stacks.cell(ref src, index, z8);

        public static ref ushort ss_value_256x16(ref MemStack256 src, int index)
            => ref Stacks.cell(ref src, index, z16);

        public static ref uint ss_value_256x32(ref MemStack256 src, int index)
            => ref Stacks.cell(ref src, index, z32);

        public static ref ulong ss_value_256x64(ref MemStack256 src, int index)
            => ref Stacks.cell(ref src, index, z64);


        public static MemStack64 init_64x8(in byte src)
            => Stacks.init(p2x6, in src);

        public static MemStack64 init_64x16(in ushort src)
            => Stacks.init(p2x6, in src);

        public static MemStack64 init_64x32(in uint src)
            => Stacks.init(p2x6, in src);

        public static MemStack64 init_64x64(in ulong src)
            => Stacks.init(p2x6, in src);

        public static MemStack128 init_128x8(in byte src)
            => Stacks.init(p2x7, in src);

        public static MemStack256 init_256x8(in byte src)
            => Stacks.init(p2x8, in src);

        public static MemStack256 init_256x32(in uint src)
            => Stacks.init(p2x8, in src);

        public static MemStack512 init_512x8(in byte src)
            => Stacks.init(p2x9, in src);

    }

}