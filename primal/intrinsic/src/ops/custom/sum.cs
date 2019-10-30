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

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static zfunc;
    using static As;

    public static partial class dinx
    {

        /// <summary>
        /// Computes the sum of the source vector components
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static ulong vsum(Vector128<ulong> x)
        {            
            return default;
        }

        /// <summary>
        /// Computes the sum of the source vector components
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static ulong vsum(Vector256<ulong> x)
        {            
            vlo(x, out var a, out var b);
            var sum = a + b;
            vhi(x, out a, out b);
            return sum + a + b;
        }
    }
}