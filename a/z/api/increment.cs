//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;

    partial class root
    {        
        /// <summary>
        /// Atomically increments a value in-place
        /// </summary>
        /// <param name="src">The value to increment in-place</param>
        [MethodImpl(Inline)]
        public static int increment(ref int src)
            => Interlocked.Increment(ref src);

        /// <summary>
        /// Atomically increments a value in-place
        /// </summary>
        /// <param name="src">The value to increment in-place</param>
        [MethodImpl(Inline)]
        public static uint increment(ref uint src)
            => (uint)As.int32(ref src);

        /// <summary>
        /// Atomically increments a value in-place
        /// </summary>
        /// <param name="src">The value to increment in-place</param>
        [MethodImpl(Inline)]
        public static long increment(ref long src)
            => Interlocked.Increment(ref src);

        /// <summary>
        /// Atomically increments a value in-place
        /// </summary>
        /// <param name="src">The value to increment in-place</param>
        [MethodImpl(Inline)]
        public static ulong increment(ref ulong src)
            => (ulong)As.int64(ref src);
    }
}