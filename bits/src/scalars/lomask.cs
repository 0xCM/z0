//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
 
    using static zfunc;
    
    partial class Bits
    {                        
        /// <summary>
        /// Reurns a sequence of N enabled bits, starting from index 0 and extending to index n - 1
        /// </summary>
        /// <typeparam name="N">The enabled bit count type</typeparam>
        [MethodImpl(Inline)]
        public static ulong lomask<N>(N n = default)
            where N : unmanaged, ITypeNat
                => NatMath.pow2m1<N>();

        /// <summary>
        /// Reurns a sequence of n enabled bits, starting from index 0 and extending to index n - 1
        /// </summary>
        /// <typeparam name="N">The enabled bit count type</typeparam>
        [MethodImpl(Inline)]
        public static ulong lomask(int n)
            => blsmsk(Pow2.pow(n));

        [MethodImpl(Inline)]
        public static ulong himask(int n)
        {
            int count = 64 - n;
            var lo = Bits.lomask(count - 1);
            var shift = 64 - count;
            return lo << shift;
        }

    }

}