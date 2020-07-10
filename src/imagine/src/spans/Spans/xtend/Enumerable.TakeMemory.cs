//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;    
    
    using static Konst;
    
    partial class XTend
    {
        /// <summary>
        /// Constructs a memory segment of specified length from a stream (allocating)
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="length">The length of the index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> TakeMemory<T>(this IEnumerable<T> src, int length)
            => src.Take(length).ToArray();

        /// <summary>
        /// Constructs a memory segment of specified length from a stream (allocating)
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="length">The length of the index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlyMemory<T> TakeReadOnlyMemory<T>(this IEnumerable<T> src, int length)
            => src.Take(length).ToMemory();

        /// <summary>
        /// Constructs an array from a specified number of elmements from a source stream after a skip (allocating)
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> TakeMemory<T>(this IEnumerable<T> src, int skip, int count)
            => src.Skip(skip).TakeMemory(count);
    }
}