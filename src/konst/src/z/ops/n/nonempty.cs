//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Produces a nonempty array from a source array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T[] nonempty<T>(T[] src)
            where T : struct
                =>  ((src == null || src.Length == 0) ? new T[1]{default} : src);  
    }
}