//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct NumericArrays
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Unconditionally converts the source values to values of parametric numeric type
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline)]
        public static T[] force<S,T>(S[] src, T[] dst)
            where T : unmanaged
            where S : unmanaged
        {
            var input = span(src);
            var count = input.Length;
            var target = span(dst);
            for(var i=0; i<count; i++)
                seek(target,(uint)i) = Numeric.force<S,T>(skip(input,(uint)i));
            return dst;
        }

        /// <summary>
        /// Unconditionally converts the source values to values of parametric numeric type
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline)]
        public static T[] force<S,T>(S[] src)
            where T : unmanaged
            where S : unmanaged
        {
            var input = span(src);
            var count = input.Length;
            var buffer = alloc<T>(count);
            var dst = buffer.ToSpan();
            for(var i=0; i<count; i++)
                seek(dst,(uint)i) = Numeric.force<S,T>(skip(input,(uint)i));
            return buffer;
        }
    }
}