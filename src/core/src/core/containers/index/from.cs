//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Index
    {
        /// <summary>
        /// Returns an index that lives at a specified adress, hopefully fixed
        /// </summary>
        /// <param name="src">The index address</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op]
        public static unsafe ref readonly Index<T> from<T>(MemoryAddress src)
            => ref @as<Index<T>>(src.Pointer());
    }
}