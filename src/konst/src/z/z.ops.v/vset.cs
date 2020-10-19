//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Produces an indexed sequence from a parameter array
        /// </summary>
        /// <param name="src">The source items</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static IndexedSeq<T> iseq<T>(params T[] src)
            => src;

        /// <summary>
        /// Creates a value index from an array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static ValueIndex<T> vindex<T>(T[] src)
            where T : struct
                => new ValueIndex<T>(src);

        /// <summary>
        /// Creates a value set from a stream
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]   
        public static ValueSet<T> vset<T>(IEnumerable<T> src)
            where T : struct
                => new ValueSet<T>(src); 

        /// <summary>
        /// Creates a value set from an array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]   
        public static ValueSet<T> vset<T>(params T[] src)
            where T : struct
                => new ValueSet<T>(src); 
    }
}