//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;

    using static Root;

    partial struct core
    {
        /// <summary>
        /// Applies a function to a value
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="f">The function to apply</param>
        /// <typeparam name="X">The source value type</typeparam>
        /// <typeparam name="Y">The output value type</typeparam>
         [MethodImpl(Inline)]
         public static Y apply<X,Y>(X x, Func<X,Y> f)
            => f(x);

        /// <summary>
        /// Atomically increments a value in-place
        /// </summary>
        /// <param name="src">The value to increment in-place</param>
        [MethodImpl(Inline), Op]
        public static long inc(ref long src)
            => Interlocked.Increment(ref src);

        /// <summary>
        /// Atomically decrements a value in-place
        /// </summary>
        /// <param name="src">The value to increment in-place</param>
        [MethodImpl(Inline), Op]
        public static long dec(ref long src)
            => Interlocked.Decrement(ref src);

        /// <summary>
        /// Atomically add a source value to a target
        /// </summary>
        /// <param name="src">The value to increment in-place</param>
        [MethodImpl(Inline), Op]
        public static long add(ref long dst, long src)
            => Interlocked.Add(ref dst, src);
    }
}