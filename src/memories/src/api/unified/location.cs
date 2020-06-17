//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;

    using static Konst;

    partial class Memories
    {
        /// <summary>
        /// Returns the memory addres of the source reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The referent type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static MemoryAddress location<T>(in T src)
            where T : unmanaged
                => Addresses.reference(src);
    }
}