//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct As
    {
        /// <summary>
        /// Presents a generic reference as a ushort pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe ushort* p16u<T>(in T r)
            where T : unmanaged
                => refptr<T,ushort>(ref edit(r));
    }
}