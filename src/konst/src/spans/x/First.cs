//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class XSpan
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T? First<T>(this ReadOnlySpan<T> src, ValuePredicate<T> predicate)
            where T : struct
        {
            var count = src.Length;
            if(count == 0)
                return null;

            ref readonly var start = ref first(src);
            for(var i=0u; i<count; i++)
            {
                ref readonly var candidate = ref skip(start,i);
                if(predicate(candidate))
                    return candidate;
            }
            return null;
        }

        /// <summary>
        /// Returns a reference to the first element of a nonempty span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T First<T>(this Span<T> src)
        {
            if(src.IsEmpty)
                ThrowEmptySpanError();
            return ref z.first(src);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool First<T>(this Span<T> src, out T dst)
        {
            if(!src.IsEmpty)
            {
                dst = first(src);
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        /// <summary>
        /// Returns a reference to the last element of a nonempty span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T Last<T>(this Span<T> src)
        {
            if(src.IsEmpty)
                ThrowEmptySpanError();
            return ref seek(src, (uint)(src.Length - 1));
        }
    }
}