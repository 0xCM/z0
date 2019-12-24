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
        public static Vector256<byte> vduplicate(N0 parity, N32 w, Vector256<byte> src)
            => v8u(dinxfp.vdup32(parity, v32f(src)));
        
        [MethodImpl(Inline)]
        public static Vector256<byte> vduplicate(N1 parity, N32 w, Vector256<byte> src)
            => v8u(dinxfp.vdup32(parity, v32f(src)));

        // [0,1,2, ... ,E,F] -> [0,1, 0,1, ..., C,D, C,D]
        [MethodImpl(Inline)]
        public static Vector256<ushort> vduplicate(N0 parity, N32 w, Vector256<ushort> src)
            => v16u(dinxfp.vdup32(parity, v32f(src)));

        // [0,1,2, ... ,E,F] -> [2,3, 2,3, ...,  E,F, E,F]
        [MethodImpl(Inline)]
        public static Vector256<ushort> vduplicate(N1 parity, N32 w, Vector256<ushort> src)
            => v16u(dinxfp.vdup32(parity, v32f(src)));

        // [0 1 2 3 4 5 6 7] -> [0 0 2 2 4 4 6 6]
        [MethodImpl(Inline)]
        public static Vector256<uint> vduplicate(N0 parity, N32 w, Vector256<uint> src)
            => v32u(dinxfp.vdup32(parity, v32f(src)));

        // [0 1 2 3 4 5 6 7] -> [1 1 3 3 5 5 7 7]

        [MethodImpl(Inline)]
        public static Vector256<uint> vduplicate(N1 parity, N32 w, Vector256<uint> src)
            => v32u(dinxfp.vdup32(parity, v32f(src)));

        // [0 1 2 3] -> [0 0 2 2]
        [MethodImpl(Inline)]
        public static Vector256<ulong> vduplicate(N0 parity, N64 w, Vector256<ulong> src)
            => v64u(dinxfp.vdup64(parity, v64f(src)));

        // [0 1 2 3] -> [1 1 3 3]
        [MethodImpl(Inline)]
        public static Vector256<ulong> vduplicate(N1 parity, N64 w, Vector256<ulong> src)
            => v64u(dinxfp.vdup64(parity, v64f(src)));
    
    }

}