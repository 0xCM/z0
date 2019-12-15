//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;


    [OpCodeProvider]
    public static class rowbits
    {
        // ~ and
        // ~ ------------------------------------------------------------------
        public static RowBits<byte> and_8u(RowBits<byte> x, RowBits<byte> y, RowBits<byte> dst)
            => RowBits.and(x,y,dst);

        public static RowBits<ushort> and_16u(RowBits<ushort> x, RowBits<ushort> y, RowBits<ushort> dst)
            => RowBits.and(x,y,dst);

        public static RowBits<uint> and_32u(RowBits<uint> x, RowBits<uint> y, RowBits<uint> dst)
            => RowBits.and(x,y,dst);

        public static RowBits<ulong> and_64u(RowBits<ulong> x, RowBits<ulong> y, RowBits<ulong> dst)
            => RowBits.and(x,y,dst);

        public static RowBits<ulong> and_64u_op(RowBits<ulong> x, RowBits<ulong> y)
            => x & y;

        // ~ xor
        // ~ ------------------------------------------------------------------
        public static RowBits<byte> xor_8u(RowBits<byte> x, RowBits<byte> y, RowBits<byte> dst)
            => RowBits.xor(x,y,dst);

        public static RowBits<ushort> xor_16u(RowBits<ushort> x, RowBits<ushort> y, RowBits<ushort> dst)
            => RowBits.xor(x,y,dst);

        public static RowBits<uint> xor_32u(RowBits<uint> x, RowBits<uint> y, RowBits<uint> dst)
            => RowBits.xor(x,y,dst);

        public static RowBits<ulong> xor_64u(RowBits<ulong> x, RowBits<ulong> y, RowBits<ulong> dst)
            => RowBits.xor(x,y,dst);

        // ~ xnor
        // ~ ------------------------------------------------------------------
        
        public static RowBits<byte> xnor_8u(RowBits<byte> x, RowBits<byte> y, RowBits<byte> dst)
            => RowBits.xnor(x,y,dst);

        public static RowBits<ushort> xnor_16u(RowBits<ushort> x, RowBits<ushort> y, RowBits<ushort> dst)
            => RowBits.xnor(x,y,dst);

        public static RowBits<uint> xnor_32u(RowBits<uint> x, RowBits<uint> y, RowBits<uint> dst)
            => RowBits.xnor(x,y,dst);

        public static RowBits<ulong> xnor_64u(RowBits<ulong> x, RowBits<ulong> y, RowBits<ulong> dst)
            => RowBits.xnor(x,y,dst);

        // ~ not
        // ~ ------------------------------------------------------------------

        public static RowBits<byte> not_8u(RowBits<byte> x, RowBits<byte> dst)
            => RowBits.not(x,dst);

        public static RowBits<ushort> not_16u(RowBits<ushort> x, RowBits<ushort> dst)
            => RowBits.not(x,dst);

        public static RowBits<uint> not_32u(RowBits<uint> x, RowBits<uint> dst)
            => RowBits.not(x,dst);

        public static RowBits<ulong> not_64u(RowBits<ulong> x, RowBits<ulong> dst)
            => RowBits.not(x,dst);

    }
}