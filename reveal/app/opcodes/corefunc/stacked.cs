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
    using static As;
    using static Stacked;

    [OpCodeProvider]
    public static class stacked
    {

        public static MemStack64 ss_alloc_64()
            => Stacks.alloc(n64);

        public static MemStack128 ss_alloc_128()
            => Stacks.alloc(n128);

        public static MemStack256 ss_alloc_256()
            => Stacks.alloc(n256);

        public static MemStack512 ss_alloc_512()
            => Stacks.alloc(n512);

        public static MemStack1024 ss_alloc_1024()
            => Stacks.alloc(n1024);

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


        public static CharStack4 ss_alloc_c4()
            => Stacks.chars(n4);

        public static CharStack8 ss_alloc_c8()
            => Stacks.chars(n8);

        public static CharStack32 ss_alloc_c32()
            => Stacks.chars(n32);

        public static CharStack64 ss_alloc_c64()
            => Stacks.chars(n64);


        public static CharStack8 ss_concat_8x8(CharStack4 head, CharStack4 tail)
            => Stacks.concat(head,tail);

        public static ref CharStack32 ss_concat_2x16_buffered(in CharStack16 head, in CharStack16 tail, ref CharStack32 dst)
            => ref Stacks.concat(head,tail, ref dst);

        public static ref CharStack32 ss_concat_2x32_buffered(in CharStack16 head, in CharStack16 tail, ref CharStack32 dst)
            => ref Stacks.concat(head,tail, ref dst);


        public static MemStack64 init_64x8(in byte src)
            => Stacks.init(n64, in src);

        public static MemStack64 init_64x16(in ushort src)
            => Stacks.init(n64, in src);

        public static MemStack64 init_64x32(in uint src)
            => Stacks.init(n64, in src);

        public static MemStack64 init_64x64(in ulong src)
            => Stacks.init(n64, in src);

        public static MemStack128 init_128x8(in byte src)
            => Stacks.init(n128, in src);

        public static MemStack256 init_256x8(in byte src)
            => Stacks.init(n256, in src);

        public static MemStack256 init_256x32(in uint src)
            => Stacks.init(n256, in src);

        public static MemStack512 init_512x8(in byte src)
            => Stacks.init(n512, in src);

        public static MemStack1024 init_1024x8(in byte src)
            => Stacks.init(n1024, in src);

    }

}