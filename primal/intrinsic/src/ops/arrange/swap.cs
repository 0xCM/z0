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
    using System.Collections.Generic;
    using System.Linq;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
        
    using static zfunc;

    partial class dinx
    {        
        [MethodImpl(NotInline)]
        static Vector128<T> swapspec<T>(N128 n, params Swap[] swaps)
            where T : unmanaged  
        {
            var len = Vector128<T>.Count;
            var src = BlockedSpan.Load(n, range(default, gmath.add(default, convert<T>(len - 1))).ToArray().AsSpan());
            var dst = src.Swap(swaps);
            return ginx.vloadu(n, in dst.Head);
        }


        [MethodImpl(Inline)]
        public static Vector128<byte> vswap(Vector128<byte> src, params Swap[] swaps)
            => vshuffle(src,swapspec<byte>(n128,swaps));

        public static Vec256<int> vswap_ref(Vector256<int> src, byte i, byte j)
        {
            Span<int> control = stackalloc int[Vector256<int>.Count];
            for(byte k=0; k<control.Length; k++)
            {
                if(k == i)        
                    control[k] = j;
                else if(k == j)
                    control[k] = i;
                else
                    control[k] = k;
            }
            return vpermvar8x32(src,ginx.vloadu(n256, head(control)));
        }

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vswaphl_ref(Vector256<byte> x)
        {
            Vector256<byte> y = default;
            y = dinx.vinsert(dinx.vhi(x), y, 0);
            y = dinx.vinsert(dinx.vlo(x), y, 1);
            return y;
        }


        [MethodImpl(Inline)]
        public static Vector256<byte> vswaphl(Vector256<byte> x)
            => dinx.vperm2x128(x,x, Perm2x128.AD);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vswaphl(Vector256<sbyte> x)
            => dinx.vperm2x128(x,x, Perm2x128.AD);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vswaphl(Vector256<short> x)
            => dinx.vperm2x128(x,x, Perm2x128.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vswaphl(Vector256<ushort> x)
            => dinx.vperm2x128(x,x, Perm2x128.AD);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vswaphl(Vector256<long> x)
            => dinx.vperm2x128(x,x, Perm2x128.AD);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vswaphl(Vector256<ulong> x)
            => dinx.vperm2x128(x,x, Perm2x128.AD);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vswaphl(Vector256<double> x)
            => dinx.vperm2x128(x,x, Perm2x128.AD);
    }

}