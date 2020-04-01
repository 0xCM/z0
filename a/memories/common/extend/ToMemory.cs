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
    
    using static Seed;
    
    partial class XTend
    {
        /// <summary>
        ///  Constructs a memory segment from the content of the (hopefully finite) stream (allocating)
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> ToMemory<T>(this IEnumerable<T> src)
            => src.ToArray();

        /// <summary>
        ///  Constructs a memory segment from the content of the (hopefully finite) stream (allocating)
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlyMemory<T> ToReadOnlyMemory<T>(this IEnumerable<T> src)
            => src.ToArray();
    }
}