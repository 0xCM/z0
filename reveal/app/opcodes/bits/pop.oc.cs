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
    public static class pop
    {
        public static void part64x1_byte(ulong src, Span<byte> dst)
            => Bits.part64x1(src, dst);

        public static void part64x1_bit(ulong src, Span<bit> dst)
            => Bits.part64x1(src, dst);
    }
}