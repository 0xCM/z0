// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    partial class XSpan
    {
        /// <summary>
        /// Renders a non-allocating mutable view over a source span segment that is presented as an individual target value
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The index of the first source element</param>
        /// <param name="length">The number of source elements required to constitute a target type</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T Singleton<S,T>(this Span<S> src, int offset = 0, int? length = null)
            where S : unmanaged
            where T : unmanaged
                => ref MemoryMarshal.AsRef<T>(src.Bytes(offset,length));
    }
}