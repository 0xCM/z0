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

    partial class Spans
    {
        /// <summary>
        /// Copies the source span to a target span begininning at a specified target offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void copy<T>(Span<T> src, Span<T> dst, int offset)
            => src.CopyTo(slice(dst,offset));
    }
}