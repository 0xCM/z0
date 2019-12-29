//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    
    using static As;
    
    partial class dinx
    {
        
        [MethodImpl(Inline)]
        public static Vector128<short> vneq(Vector128<short> x, Vector128<short> y)
            => vcompact(vneq(vinflate(x,n256,z32i), vinflate(y,n256,z32i)),n128,z16i);
        
        [MethodImpl(Inline)]
        public static Vector128<ushort> vneq(Vector128<ushort> x, Vector128<ushort> y)
            => vcompact(vneq(vinflate(x,n256,z32), vinflate(y,n256,z32)),n128,z16);
        
        [MethodImpl(Inline)]
        public static Vector128<int> vneq(Vector128<int> x, Vector128<int> y)
            => v32i(dinxfp.vneq(v32f(x),v32f(y)));

        [MethodImpl(Inline)]
        public static Vector128<uint> vneq(Vector128<uint> x, Vector128<uint> y)
            => v32u(dinxfp.vneq(v32f(x),v32f(y)));

        [MethodImpl(Inline)]
        public static Vector128<long> vneq(Vector128<long> x, Vector128<long> y)
            => v64i(dinxfp.vneq(v64f(x),v64f(y)));

        [MethodImpl(Inline)]
        public static Vector128<ulong> vneq(Vector128<ulong> x, Vector128<ulong> y)
            => v64u(dinxfp.vneq(v64f(x),v64f(y)));

        [MethodImpl(Inline)]
        public static Vector256<int> vneq(Vector256<int> x, Vector256<int> y)
            => v32i(dinxfp.vneq(v32f(x),v32f(y)));

        [MethodImpl(Inline)]
        public static Vector256<uint> vneq(Vector256<uint> x, Vector256<uint> y)
            => v32u(dinxfp.vneq(v32f(x),v32f(y)));

        [MethodImpl(Inline)]
        public static Vector256<long> vneq(Vector256<long> x, Vector256<long> y)
            => v64i(dinxfp.vneq(v64f(x),v64f(y)));

        [MethodImpl(Inline)]
        public static Vector256<ulong> vneq(Vector256<ulong> x, Vector256<ulong> y)
            => v64u(dinxfp.vneq(v64f(x),v64f(y)));

    }

}