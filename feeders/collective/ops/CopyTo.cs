//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Collective;

    partial class CollectiveOps
    {

        /// <summary>
        /// Copies the source span to a target span begininning at a specified target offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline)]
        public static void CopyTo<T>(this Span<T> src, Span<T> dst, int offset)
            => src.CopyTo(dst.Slice(offset));

        /// <summary>
        /// Copies the source span to a target span begininning at a specified target offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline)]
        public static void CopyTo<T>(this ReadOnlySpan<T> src, Span<T> dst, int offset)
            => src.CopyTo(dst.Slice(offset));

        /// <summary>
        /// Copies a source list to a target array
        /// </summary>
        /// <param name="src">The list containing the elements to copy</param>
        /// <param name="dst">The array that will receive the copied elements</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void CopyTo<T>(this IReadOnlyList<T> src, T[] dst)
        {
            if(src.Count > dst.Length)
                throw new ArgumentException("The source list is bigger than the target array");

            for(var i=0; i< src.Count; i++)
                dst[i] = src[i];
        }

    }
}