//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
        
    using static zfunc;    


    public static class ModOps
    {
        [MethodImpl(Inline)]
        public static ulong multiplier(ulong n)
            => (ulong.MaxValue / n) + 1;

        /// <summary>
        /// Computes a % N
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public static uint mod(ulong m, ulong n, uint a)
            => (uint) Math128.mulhi(m * a, n);

        /// <summary>
        /// Computes the quotient a / N
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public static uint div(ulong m, ulong n, uint a)        
            => (uint) Math128.mulhi(m, a);

        /// <summary>
        /// Computes whether a % n == 0
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public static bool divisible(ulong m, ulong n, uint a)
            => a * m <= m - 1; 

        
        /// <summary>
        /// Computes (a + b) mod n
        /// </summary>
        [MethodImpl(Inline)]
        public static uint add(ulong m, ulong n, uint a, uint b)
            => mod(m,n, a + b);


        /// <summary>
        /// Computes (a * b) mod n
        /// </summary>
        [MethodImpl(Inline)]
        public static uint mul(ulong m, ulong n, uint a, uint b)
            => mod(m,n, a * b);

    }

}