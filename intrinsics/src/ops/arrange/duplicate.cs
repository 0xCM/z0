//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;
    using static As;

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vector256<byte> vduplicate(N0 parity, N32 width, Vector256<byte> src)
            => v8u(dfp.vduplicate(parity, v32f(src)));

        [MethodImpl(Inline)]
        public static Vector256<byte> vduplicate(N1 parity, N32 width, Vector256<byte> src)
            => v8u(dfp.vduplicate(parity, v32f(src)));

        // [0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F] -> [0,1, 0,1, 4,5, 4,5, 8,9, 8,9, C,D, C,D]
        [MethodImpl(Inline)]
        public static Vector256<ushort> vduplicate(N0 parity, N32 width, Vector256<ushort> src)
            => v16u(dfp.vduplicate(parity, v32f(src)));

        // [0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F] -> [2,3, 2,3, 6,7, 6,7, A,B, A,B, E,F, E,F]
        [MethodImpl(Inline)]
        public static Vector256<ushort> vduplicate(N1 parity, N32 width, Vector256<ushort> src)
            => v16u(dfp.vduplicate(parity, v32f(src)));

        // [0 1 2 3 4 5 6 7] -> [0 0 2 2 4 4 6 6]

        [MethodImpl(Inline)]
        public static Vector256<uint> vduplicate(N0 parity, N32 width, Vector256<uint> src)
            => v32u(dfp.vduplicate(parity, v32f(src)));

        // [0 1 2 3 4 5 6 7] -> [1 1 3 3 5 5 7 7]

        [MethodImpl(Inline)]
        public static Vector256<uint> vduplicate(N1 parity, N32 width, Vector256<uint> src)
            => v32u(dfp.vduplicate(parity, v32f(src)));

        // [0 1 2 3 4 5 6 7] -> ([0 0 2 2 4 4 6 6], [1 1 3 3 5 5 7 7])
        [MethodImpl(Inline)]
        public static void vduplicate(N32 width, Vector256<uint> src, out Vector256<uint> even, out Vector256<uint> odd)
        {
            even = vduplicate(n0,width,src);
            odd = vduplicate(n1,width,src);
        }

        [MethodImpl(Inline)]
        public static Vector256<ulong> vduplicate(N0 parity, N32 width, Vector256<ulong> src)
            => v64u(dfp.vduplicate(parity, v32f(src)));

        [MethodImpl(Inline)]
        public static Vector256<ulong> vduplicate(N1 parity, N32 width, Vector256<ulong> src)
            => v64u(dfp.vduplicate(parity, v32f(src)));
    }

}