//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm.Data;

    using static Seed;

    using Store8 = System.Runtime.Intrinsics.Vector256<byte>;
    using Store16 = System.Runtime.Intrinsics.Vector256<ushort>;
    using Store32 = System.Runtime.Intrinsics.Vector256<uint>;
    using Store64 = System.Runtime.Intrinsics.Vector256<ulong>;

    partial class CpuStorage
    {        
        [MethodImpl(Inline), Init]
        public static Bank8x16 init(W8 w, N16 n, Store8 src)
            => new Bank8x16(src);

        [MethodImpl(Inline), Init]
        public static Bank8x32 init(W8 w, N32 n, Store8 a)
            => new Bank8x32(a);

        [MethodImpl(Inline), Init]
        public static Bank16x16 init(W16 w, N16 n, Store16 a)
            => new Bank16x16(a);

        [MethodImpl(Inline), Init]
        public static Bank16x32 init(W16 w, N16 n, Store16 a, Store16 b)
            => new Bank16x32(a,b);

        [MethodImpl(Inline), Init]
        public static Bank32x16 init(W32 w, N16 n, Store32 a, Store32 b)
            => new Bank32x16(a,b);

        [MethodImpl(Inline), Init]
        public static Bank32x32 init(W32 w, N32 n, Store32 a, Store32 b, Store32 c, Store32 d)
            => new Bank32x32(a,b,c,d);

        [MethodImpl(Inline), Init]
        public static Bank64x16 init(W64 w, N16 n, Store64 a, Store64 b, Store64 c, Store64 d)
            => new Bank64x16(a,b,c,d);

        [MethodImpl(Inline), Init]
        public static Bank128x2 init(W128 w, N2 n, Store8 a)
            => new Bank128x2(a);

        [MethodImpl(Inline), Init]
        public static Bank128x4 init(W128 w, N4 n, Store8 a, Store8 b)
            => new Bank128x4(a,b);

        [MethodImpl(Inline), Init]
        public static Bank256x2 init(W256 w, N2 n, Store8 a, Store8 b)
            => new Bank256x2(a,b);

        [MethodImpl(Inline), Init]
        public static Bank256x4 init(W256 w, N4 n, Store8 a, Store8 b, Store8 c, Store8 d)
            => new Bank256x4(a,b,c,d);

        [MethodImpl(Inline), Init]
        public static Bank512x2 init(W512 w, N2 n, Store8 a, Store8 b, Store8 c, Store8 d)
            => new Bank512x2(a,b,c,d);
    }
}