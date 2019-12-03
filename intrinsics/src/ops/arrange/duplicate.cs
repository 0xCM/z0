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
        public static Vector256<byte> vdup32(N0 parity, Vector256<byte> src)
            => v8u(dfp.vdup32(parity, v32f(src)));
        
        [MethodImpl(Inline)]
        public static Vector256<byte> vdup32(N1 parity, Vector256<byte> src)
            => v8u(dfp.vdup32(parity, v32f(src)));

        [MethodImpl(Inline)]
        public static void vduplicate(Vector256<byte> src, out Vector256<byte> even, out Vector256<byte> odd)
        {
            even = vdup32(n0,src);
            odd = vdup32(n1,src);
        }

        // [0,1,2, ... ,E,F] -> [0,1, 0,1, ..., C,D, C,D]
        [MethodImpl(Inline)]
        public static Vector256<ushort> vdup32(N0 parity, Vector256<ushort> src)
            => v16u(dfp.vdup32(parity, v32f(src)));

        // [0,1,2, ... ,E,F] -> [2,3, 2,3, ...,  E,F, E,F]
        [MethodImpl(Inline)]
        public static Vector256<ushort> vdup32(N1 parity, Vector256<ushort> src)
            => v16u(dfp.vdup32(parity, v32f(src)));

        [MethodImpl(Inline)]
        public static void vdup32(Vector256<ushort> src, out Vector256<ushort> even, out Vector256<ushort> odd)
        {
            even = vdup32(n0,src);
            odd = vdup32(n1,src);
        }

        // [0 1 2 3 4 5 6 7] -> [0 0 2 2 4 4 6 6]

        [MethodImpl(Inline)]
        public static Vector256<uint> vdup32(N0 parity, Vector256<uint> src)
            => v32u(dfp.vdup32(parity, v32f(src)));

        // [0 1 2 3 4 5 6 7] -> [1 1 3 3 5 5 7 7]

        [MethodImpl(Inline)]
        public static Vector256<uint> vdup32(N1 parity, Vector256<uint> src)
            => v32u(dfp.vdup32(parity, v32f(src)));

        // [0 1 2 3 4 5 6 7] -> ([0 0 2 2 4 4 6 6], [1 1 3 3 5 5 7 7])
        [MethodImpl(Inline)]
        public static void vdup32(Vector256<uint> src, out Vector256<uint> even, out Vector256<uint> odd)
        {
            even = vdup32(n0, src);
            odd = vdup32(n1, src);
        }

        // [0 1 2 3] -> [0 0 2 2]
        [MethodImpl(Inline)]
        public static Vector256<ulong> vdup64(N0 parity, Vector256<ulong> src)
            => v64u(dfp.vdup64(parity, v64f(src)));

        // [0 1 2 3] -> [1 1 3 3]
        [MethodImpl(Inline)]
        public static Vector256<ulong> vdup64(N1 parity, Vector256<ulong> src)
            => v64u(dfp.vdup64(parity, v64f(src)));
    
        // [0 1 2 3] -> ([0 0 2 2],[1 1 3 3])
        [MethodImpl(Inline)]
        public static void vdup64(Vector256<ulong> src, out Vector256<ulong> even, out Vector256<ulong> odd)
        {
            even = vdup64(n0,src);
            odd = vdup64(n1,src);
        }
    }

}