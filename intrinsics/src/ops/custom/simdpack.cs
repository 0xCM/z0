//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;
    using static dinx;
    using static ginx;
    using static As;

    /// <summary>
    /// Port of selected algorithms from https://github.com/lemire/FastPFOR
    /// </summary>
    public static class SimdPack
    {
        /// <summary>
        /// Packs 128 isolated bits into a 128-bitspan
        /// </summary>
        /// <param name="src">The source bits to condense</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> pack(ConstNatBlock<N128,bit> src)
            => pack(n1, n32, in head(src.As<uint>()));

        [MethodImpl(Inline)]
        public static Vector128<uint> pack(N1 width, ConstNatBlock<N128,uint> src)
            => pack(width, n32, in head(src));

        [MethodImpl(Inline)]
        static void pack1(ref Vector128<uint> xmm0, ref Vector128<uint> xmm1, in uint src, byte step, int offset)
        {
            xmm0 = vor(xmm0, vsll(xmm1, step));
            xmm1 = vload(n128, in skip(in src, offset));
        }

        static Vector128<uint> pack(N1 width, N32 n, in uint src)
        {
            const int step = 4;
            var nv = n128;
            var current = 0;
                        
            var xmm1 = vload(nv, in src);            
            var xmm0 = xmm1;            
            xmm1 = vload(nv, in skip(in src, current += step));

            pack1(ref xmm0, ref xmm1, in src, 1, current += step);
            pack1(ref xmm0, ref xmm1, in src, 2, current += step);
            pack1(ref xmm0, ref xmm1, in src, 3, current += step);
            pack1(ref xmm0, ref xmm1, in src, 4, current += step);
            pack1(ref xmm0, ref xmm1, in src, 5, current += step);
            pack1(ref xmm0, ref xmm1, in src, 6, current += step);
            pack1(ref xmm0, ref xmm1, in src, 7, current += step);
            pack1(ref xmm0, ref xmm1, in src, 8, current += step);
            pack1(ref xmm0, ref xmm1, in src, 9, current += step);
            pack1(ref xmm0, ref xmm1, in src, 10, current += step);
            pack1(ref xmm0, ref xmm1, in src, 11, current += step);
            pack1(ref xmm0, ref xmm1, in src, 12, current += step);
            pack1(ref xmm0, ref xmm1, in src, 13, current += step);
            pack1(ref xmm0, ref xmm1, in src, 14, current += step);
            pack1(ref xmm0, ref xmm1, in src, 15, current += step);
            pack1(ref xmm0, ref xmm1, in src, 16, current += step);
            pack1(ref xmm0, ref xmm1, in src, 17, current += step);
            pack1(ref xmm0, ref xmm1, in src, 18, current += step);
            pack1(ref xmm0, ref xmm1, in src, 19, current += step);
            pack1(ref xmm0, ref xmm1, in src, 20, current += step);
            pack1(ref xmm0, ref xmm1, in src, 21, current += step);
            pack1(ref xmm0, ref xmm1, in src, 22, current += step);
            pack1(ref xmm0, ref xmm1, in src, 23, current += step);
            pack1(ref xmm0, ref xmm1, in src, 24, current += step);
            pack1(ref xmm0, ref xmm1, in src, 25, current += step);
            pack1(ref xmm0, ref xmm1, in src, 26, current += step);
            pack1(ref xmm0, ref xmm1, in src, 27, current += step);
            pack1(ref xmm0, ref xmm1, in src, 28, current += step);
            pack1(ref xmm0, ref xmm1, in src, 29, current += step);
            pack1(ref xmm0, ref xmm1, in src, 30, current += step);
            pack1(ref xmm0, ref xmm1, in src, 31, current += step);
            return xmm0;
        }

    }

}