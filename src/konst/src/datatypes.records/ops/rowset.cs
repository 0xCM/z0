//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Records
    {
        /// <summary>
        /// Creates a <see cref='Rowset{T}'/>
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The record type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Rowset<T> rowset<T>(T[] src)
            where T : struct
                => new Rowset<T>(src);
    }
}