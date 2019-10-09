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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
        
    using static zfunc;

    partial class dinx
    {        
        public static Vec256<int> swap(Vec256<int> src, byte i, byte j)
        {
            Span<int> control = stackalloc int[Vec256<int>.Length];
            for(byte k=0; k<control.Length; k++)
            {
                if(k == i)        
                    control[k] = j;
                else if(k == j)
                    control[k] = i;
                else
                    control[k] = k;
            }
            return perm8x32(src, Vec256.Load(control));
        }


        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> swaphl_ref(in Vec256<byte> x)
        {
            Vec256<byte> y = default;
            y = dinx.insert(dinx.hi(x), y, 0);
            y = dinx.insert(dinx.lo(x), y, 1);
            return y;
        }

        [MethodImpl(Inline)]
        public static Vec256<byte> swaphl(in Vec256<byte> x)
            => dinx.vperm2x128(x,x, Perm2x128.AD);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> swaphl(in Vec256<sbyte> x)
            => dinx.vperm2x128(x,x, Perm2x128.AD);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<short> swaphl(in Vec256<short> x)
            => dinx.vperm2x128(x,x, Perm2x128.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> swaphl(in Vec256<ushort> x)
            => dinx.vperm2x128(x,x, Perm2x128.AD);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<long> swaphl(in Vec256<long> x)
            => dinx.vperm2x128(x,x, Perm2x128.AD);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> swaphl(in Vec256<ulong> x)
            => dinx.vperm2x128(x,x, Perm2x128.AD);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> swaphl(in Vec256<double> x)
            => dinx.vperm2x128(x,x, Perm2x128.AD);
    }

}