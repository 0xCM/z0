//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static Part;
    using static BitMasks.Literals;

    partial struct cpu
    {
        [MethodImpl(Inline), MoveMask]
        public static ushort vtakemask(Vector128<byte> src, byte offset, [Imm] byte index)
            => vmask16u(vsllx(src, offset), index);

        [MethodImpl(Inline), MoveMask]
        public static ushort vtakemask(Vector128<ushort> src, byte offset, [Imm] byte index)
            => vmask16u(vsllx(src, offset), index);

        [MethodImpl(Inline), MoveMask]
        public static ushort vtakemask(Vector128<uint> src, Vector128<uint> offsets, [Imm] byte index)
            => vmask16u(vsllv(src, offsets), index);

        [MethodImpl(Inline), MoveMask]
        public static ushort vtakemask(Vector128<ulong> src, Vector128<ulong> offsets, [Imm] byte index)
            => vmask16u(vsllv(src, offsets), index);

        [MethodImpl(Inline), MoveMask]
        public static uint vtakemask(Vector256<byte> src, [Imm] byte offset, [Imm] byte index)
            => vmask32u(vsllx(src, offset), index);

        [MethodImpl(Inline), MoveMask]
        public static uint vtakemask(Vector256<ushort> src, [Imm] byte offset, [Imm] byte index)
            => vmask32u(vsllx(src, offset), index);

        [MethodImpl(Inline), MoveMask]
        public static uint vtakemask(Vector256<uint> src, Vector256<uint> offsets, [Imm] byte index)
            => vmask32u(vsllv(src, offsets), index);

        [MethodImpl(Inline), MoveMask]
        public static uint vtakemask(Vector256<ulong> src, Vector256<ulong> offsets, [Imm] byte index)
            => vmask32u(vsllv(src, offsets), index);

        [MethodImpl(Inline), Op]
        static ulong maskpart(uint src, int offset)
            => BitMasks.scatter((ulong)((byte)(src >> offset)), Msb64x8x1);

        [MethodImpl(Inline), Op]
        static ulong maskpart(uint src, int offset, ulong mask)
            => BitMasks.scatter((ulong)((byte)(src >> offset)), mask);
    }
}