//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    unsafe partial struct Pointers
    {
        /// <summary>
        /// Reveals the memory location to which the represented pointer points
        /// </summary>
        /// <param name="src">The source pointer</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static MemoryAddress address<T>(in Ptr<T> src)
            where T : unmanaged
                => src.P;
    }
}