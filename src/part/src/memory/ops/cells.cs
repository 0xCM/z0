//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
        /// <summary>
        /// Computes the whole number of T-cells covered by a specified <see cref='MemoryRange'/>
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint cells<T>(MemoryRange src)
            => (uint)(src.Length/size<T>());
    }
}