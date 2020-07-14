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
    public readonly struct ValueIndex
    {
        /// <summary>
        /// Produces the empty index
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ValueIndex<T> Zero<T>()
            where T : struct
                => new ValueIndex<T>(default(T));

        /// <summary>
        /// Tests the source index for non-emptiness
        /// </summary>
        /// <param name="src">The index to test</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bool NonEmpty<T>(in ValueIndex<T> src)
            where T : struct
                => src.Data != null && src.Data.Length != 0 && not(pseudoempty(src));
                
        /// <summary>
        /// Tests the source index for emptiness
        /// </summary>
        /// <param name="src">The index to test</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bool Empty<T>(in ValueIndex<T> src)
            where T : struct
                => src.Data == null || src.Data.Length == 0 || pseudoempty(src);

        /// <summary>
        /// Creates an index from an array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ValueIndex<T> create<T>(T[] src)
            where T : struct
                => new ValueIndex<T>(src);

        /// <summary>
        /// Creates an index from a stream
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ValueIndex<T> create<T>(IEnumerable<T> src)
            where T : struct
                => new ValueIndex<T>(src.Array());
        
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        internal static bool pseudoempty<T>(in ValueIndex<T> src)
            where T : struct
                => src.Data.Length == 1 && DataMembers.empty(src.Offset) && DataMembers.empty(src.Data[0]);
    }
}