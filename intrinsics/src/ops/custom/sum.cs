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
    using static As;

    public static partial class dinx
    {
        /// <summary>
        /// Computes the sum of the source vector components
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static ulong vsum(Vector128<ulong> x)
            => x.GetElement(0) + x.GetElement(1);

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