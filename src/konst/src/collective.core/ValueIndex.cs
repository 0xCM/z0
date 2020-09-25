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
        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static ValueIndex<T> Zero<T>()
            where T : struct
                => default;

        /// <summary>
        /// Tests the source index for non-emptiness
        /// </summary>
        /// <param name="src">The index to test</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static bool NonEmpty<T>(in ValueIndex<T> src)
            where T : struct
                => src.Data != null && src.Data.Length != 0;
                
        /// <summary>
        /// Tests the source index for emptiness
        /// </summary>
        /// <param name="src">The index to test</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static bool Empty<T>(in ValueIndex<T> src)
            where T : struct
                => src.Data == null || src.Data.Length == 0;
    }
}