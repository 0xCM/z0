//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Linq;

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;

    /// <summary>
    /// Reifies and provides storage for common 128-bit vector patterns
    /// </summary>
    public readonly struct Vec128Pattern<T> 
        where T : unmanaged
    {
        static int Length => Vector128<T>.Count;

        /// <summary>
        /// Creates a vector with incrementing components
        /// v[0] = first and v[i+1] = v[i] + 1 for i=1...N-1
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> Increments(T first = default, params Swap[] swaps)
        {
            var src = Span128.Load(range(first, gmath.add(first, convert<T>(Length - 1))).ToArray().AsSpan());
            return Vec128.Load(src.Swap(swaps));
        }

    }
}

