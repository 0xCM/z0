//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {
        
        [MethodImpl(Inline)]
        public static bool eq(BitMatrix16 A, BitMatrix16 B)
            => testz(andn(A,B));

        [MethodImpl(Inline)]
        public static bool eq(BitMatrix32 A, BitMatrix32 B)
            => testz(andn(A,B));

        [MethodImpl(Inline)]
        public static bool eq(BitMatrix64 A, BitMatrix64 B)
            => testz(andn(A,B));

        [MethodImpl(Inline)]
        static unsafe Vec256<uint> vload256(ref uint head)
            => Avx.LoadVector256(refptr(ref head));

    }

}