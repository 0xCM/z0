//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static System.Runtime.Intrinsics.X86.Bmi2;

    using static memory;

    partial class math
    {
        /// <summary>
        /// Computes the unsigned 64-bit product of two unsigned 32-bit integers
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong mul64(uint x, uint y)
        {
            var dst = 0u;
            return (((ulong)MultiplyNoFlags(x, y, gptr(dst))) << 32) | dst;
        }
    }
}