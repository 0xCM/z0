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
        /// Presents a generic reference as an int64 pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe long* p64u<T>(in T src)
            where T : unmanaged
                => refptr<T,long>(ref edit(src));
    }
}