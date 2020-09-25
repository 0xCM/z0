//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct Indexed
    {        
        /// <summary>
        /// Creates an indexed sequence from a stream
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static IndexedSeq<T> seq<T>(IEnumerable<T> src)
            => new IndexedSeq<T>(src); 

        /// <summary>
        /// Creates an indexed sequence from a parameter array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static IndexedSeq<T> seq<T>(params T[] src)
            => new IndexedSeq<T>(src); 

        /// <summary>
        /// Creates an index from an array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static ValueIndex<T> values<T>(T[] src)
            where T : struct
                => new ValueIndex<T>(src);

        /// <summary>
        /// Creates an index from a stream
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static ValueIndex<T> values<T>(IEnumerable<T> src)
            where T : struct
                => new ValueIndex<T>(src.Array());    
    }
}