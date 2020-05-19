//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    partial class gbits
    {
        /// <summary>
        /// Defines a mask that disables a sequence of bits
        /// </summary>
        /// <param name="start">The index at which to begin</param>
        /// <param name="count">The number of bits to disable</param>
        /// <typeparam name="T">The primal type over which the mask is defined</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T eraser<T>(byte start, byte count)
            where T : unmanaged
                => gmath.xor(Literals.maxval<T>(), gmath.sll(BitMask.lo<T>(count - 1), start));        
    }
}