//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct sys
    {
        [MethodImpl(Options), Op, Closures(Closure)]
        public static ref readonly Span<T> clear<T>(in Span<T> src)
            => ref proxy.clear(src);

        /// <summary>
        /// Fills an array with the element type's default value
        /// </summary>
        /// <param name="dst">The source array</param>
        /// <typeparam name="T">The array element type</typeparam>
        [MethodImpl(Options), Op, Closures(Closure)]
        public static T[] clear<T>(T[] dst)
            where T : struct
        {
            if(dst == null)
                return empty<T>();
            else
            {
                proxy.fill(dst, default(T));
                return dst;
            }
        }
    }
}