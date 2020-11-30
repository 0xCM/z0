//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct NatPack
    {
        /// <summary>
        /// Packs the least significant bit from <see cref='n8'/> <see cref='w32'/> <see cref='uint'/> source values to a <see cref='w8'/> bit <see cref='byte'/> target
        /// </summary>
        /// <param name="src">The intput sequence</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref byte pack(in NatSpan<N8,uint> src, ref byte dst)
        {
            dst = Bits.pack8x32x1(src.First);
            return ref dst;
        }

        /// <summary>
        /// Packs the least significant bit from <see cref='n16'/> <see cref='w32'/> <see cref='uint'/> source values to a <see cref='w16'/> bit <see cref='ushort'/> target
        /// </summary>
        /// <param name="src">The intput sequence</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref ushort pack(in NatSpan<N16,uint> src, ref ushort dst)
        {
            dst = Bits.pack16x32x1(src.First, n16, w16);
            return ref dst;
        }

        /// <summary>
        /// Packs the least significant bit from <see cref='n32'/> <see cref='w32'/> <see cref='uint'/> source values to a <see cref='w32'/> bit <see cref='uint'/> target
        /// </summary>
        /// <param name="src">The intput sequence</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref uint pack(in NatSpan<N32,uint> src, ref uint dst)
        {
            dst = Bits.pack32x32x1(src.First, ref dst);
            return ref dst;
        }

        /// <summary>
        /// Packs the least significant bit from <see cref='n64'/> <see cref='w32'/> <see cref='uint'/> source values to a <see cref='w64'/>  <see cref='ulong'/> target
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref ulong pack(in NatSpan<N64,uint> src, ref ulong dst)
        {
            dst = Bits.pack64x32x1(src.First, n64, w64);
            return ref dst;
        }
    }
}
