//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public static class ByteReader
    {
        /// <summary>
        /// Extracts a specified count of elements from the source and merges the
        /// elements to produce a target value
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The source offset</param>
        /// <param name="count">The number of source elements to read</param>
        /// <param name="dst">The target element</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T Read<S,T>(Span<S> src, int offset, int count)
            where S : unmanaged
            where T : unmanaged
                => ref head(src.Slice(offset, count).As<S,T>());

        /// <summary>
        /// Extracts a specified count of elements from the head of the source source and merges the
        /// elements to produce a target value
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of source elements to read</param>
        /// <param name="dst">The target element</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T Read<S,T>(Span<S> src, int count, ref T dst)
            where S : unmanaged
            where T : unmanaged
                => ref head(src.Slice(count).As<S,T>());
    }


}