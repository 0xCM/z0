//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public static partial class XTend
    {
        public static T? First<T>(this ReadOnlySpan<T> src, ValuePredicate<T> predicate)
            where T : struct
        {
            var count = src.Length;
            ref readonly var start = ref z.first(src);
            for(var i=0u; i<count; i++)
            {
                ref readonly var candidate = ref z.skip(start,i);
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
        [MethodImpl(Inline)]
        public static ref T First<T>(this Span<T> src)
        {
            if(src.IsEmpty)
                ThrowEmptySpanError();
            return ref z.first(src);
        }

        /// <summary>
        /// Returns a reference to the last element of a nonempty span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T Last<T>(this Span<T> src)
        {
            if(src.IsEmpty)
                ThrowEmptySpanError();
            return ref z.seek(src, (uint)(src.Length - 1));
        }
    }
}